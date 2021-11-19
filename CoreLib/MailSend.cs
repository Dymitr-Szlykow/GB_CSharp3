using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace CoreLib
{
    public class MailSendCore
    {
        protected static Regex _MailAdressTemplate = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6}");
        protected static Regex _DeleteMe = new Regex("^[a-zA-Z]{1}[a-zA-Z0-9]{1,9}$");

        //public MailAddress Destination { get; protected set; }
        public MailAddress Sender { get; protected set; }
        public MailMessage message;  // TODO

        protected SmtpClient smtpClient;
        public string SmtpClientHost { get => smtpClient.Host; }
        public int SmtpClientPort { get => smtpClient.Port; }

        public ObservableCollection<string> Attachments { get; set; }
        public ObservableCollection<MailAddress> Destinations { get; set; }


        public MailSendCore()
        {
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("somemail@gmail.com", "mypassword"),
                EnableSsl = true
            };
        }

        public MailSendCore(SmtpClient client)
        {
            smtpClient = client;
        }


        public bool SetSender(string address)
        {
            if (AddressFits(address))
            {
                Sender = new MailAddress(address);
                return true;
            }
            else return false;
        }

        public bool SetSender(string address, string name)
        {
            if (AddressFits(address))
            {
                Sender = new MailAddress(address, name);
                return true;
            }
            else return false;
        }

        //public bool SetDestination(string address)
        //{
        //    if (AddressFits(address))
        //    {
        //        Destination = new MailAddress(address);
        //        return true;
        //    }
        //    else return false;
        //}

        public bool SetSmtpClient()
        {
            // TODO
            return false;
        }

        public bool SetClientHost(string input)
        {
            smtpClient.Host = input;
            return true;
        }

        public bool SetClientPort(string input)
        {
            if (int.TryParse(input, out int res))
            {
                smtpClient.Port = res;
                return true;
            }
            else return false;
        }


        public bool AddressFits(string address) => _MailAdressTemplate.IsMatch(address);

        public static (string, int) GetClient(string address)  // TODO
        {
            string[] temp = address.Split(new char[] { '@', '.' }, StringSplitOptions.None);
            switch (temp[1])
            {
                case "yandex":
                    return ("smtp.yandex.ru", 25);
                case "gmail":
                    return ("smtp.gmail.com", 58);
                case "mail":
                    return ("smtp.mail.ru", 25);
                default:
                    throw new NotImplementedException();
            }
        }


        protected MailMessage FormMessage(string subject, string body)
        {
            var res = new MailMessage(Sender, Destinations[0])
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };

            if (Destinations.Count > 1)
            {
                for (int i = 1; i < Destinations.Count; i++) res.Bcc.Add(Destinations[i]);
            }

            if (Attachments != null)
            {
                foreach (var el in Attachments) res.Attachments.Add(new Attachment(el));
            }
            return res;
        }

        protected MailMessage FormHTMLMessage(string subject, string body)
        {
            var res = new MailMessage(Sender, Destinations[0])
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            if (Destinations.Count > 1)
            {
                for (int i = 1; i < Destinations.Count; i++) res.To.Add(Destinations[i]);
            }

            if (Attachments != null)
            {
                foreach (var el in Attachments) res.Attachments.Add(new Attachment(el));
            }
            return res;
        }

        public (MailMessage, string) Send(MailMessage message)
        {
            var report = new StringBuilder($"! ПОПЫТКА ОТПРАВИТЬ ПИСЬМО !");
            if (message.Subject?.Length > 0) _ = report.AppendLine($"\n\tна тему: \"{message.Subject}\"");

            if (message.To.Count == 1) _ = report.AppendLine($"\tадресат: {message.To}");
            else if (message.To.Count > 1)
            {
                report.AppendLine($"\tполучатели:");
                foreach (MailAddress el in message.To) _ = report.AppendLine("\t- " + el.Address);
            }

            if (message.Body?.Length > 0) _ = report.AppendLine($"\n\"" + message.Body + "\"");

            if (message.Attachments.Count == 1)
                report.AppendLine($"прикрепленный файл: {message.Attachments[0].Name}");
            else if (message.Attachments.Count > 1)
            {
                _ = report.AppendLine($"\nприкрепленные файлы:");
                foreach (Attachment el in message.Attachments) _ = report.AppendLine("\t" + el.Name);
            }

            _ = report.AppendLine($"\nЖелаете причинить соответствующие меры субъекту по адресу {message.From.Address}?");
            //smtpClient.Send(message);
            Debug.WriteLine(report.ToString());
            return (message, report.ToString());
        }

        protected void Send() => smtpClient.Send(message);  // TODO
        public string Send(string subject, string body) => Send(FormMessage(subject, body)).Dispose();
        public string SendAsHTML(string subject, string body) => Send(FormHTMLMessage(subject, body)).Dispose();
        public string SendMakingHTML(string subject, string body) => Send(FormHTMLMessage(subject, "<p>" + body + "</p>")).Dispose();
    }

    public static class Extensions
    {
        public static string Dispose(this (MailMessage, string) theTuple)
        {
            theTuple.Item1.Dispose();
            return theTuple.Item2;
        }
    }
}
