using System;
using System.Collections.Generic;
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

        public MailAddress Destination { get; protected set; }
        public MailAddress Sender { get; protected set; }
        public MailMessage message;  // TODO
        protected SmtpClient smtpClient;

        public string SmtpClientHost { get => smtpClient.Host; }
        public int SmtpClientPort { get => smtpClient.Port; }



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

        public bool SetDestination(string address)
        {
            if (AddressFits(address))
            {
                Destination = new MailAddress(address);
                return true;
            }
            else return false;
        }

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
            return new MailMessage(Sender, Destination)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };
        }
        protected MailMessage FormHTMLMessage(string subject, string body)
        {
            return new MailMessage(Sender, Destination)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
        }

        protected void Send() => smtpClient.Send(message);  // TODO
        public (MailMessage, string) Send(MailMessage message)
        {
            string report = $"! ПОПЫТКА ОТПРАВИТЬ ПИСЬМО !" +
                $"\n\tна тему: \"{message.Subject}\"" +
                $"\n\tадресат: {message.To}" +
                $"\n\n\"" + message.Body +
                $"\"\n\nЖелаете причинить соответствующие меры субъекту по адресу {message.From.Address}?";
            //smtpClient.Send(message);
            Debug.WriteLine(report);
            return (message, report);
        }
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
