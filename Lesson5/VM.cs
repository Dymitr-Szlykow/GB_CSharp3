using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Input;

namespace Lesson5
{
    public class VM : INotifyPropertyChanged, IDataErrorInfo
    {
        private readonly Model core = new Model();
        private readonly List<Thread> threads = new List<Thread>();
        private bool canReadArray = false;
        private bool canSetArray = false;


        #region ЗАДАЧА 1
        private string _Input;
        private ulong inputNumber;
        private string _factorialOutput;
        private string _factorialTime;
        private string _sumOutput;
        private string _sumTime;

        public string Input
        {
            get => _Input;
            set
            {
                _Input = value;
                NotifyPropertyChanged();
            }
        }
        public string FactorialOutput
        {
            get => _factorialOutput;
            set
            {
                _factorialOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string FactorialTime
        {
            get => _factorialTime;
            set
            {
                _factorialTime = value;
                NotifyPropertyChanged();
            }
        }
        public string SumOutput
        {
            get => _sumOutput;
            set
            {
                _sumOutput = value;
                NotifyPropertyChanged();
            }
        }
        public string SumTime
        {
            get => _sumTime;
            set
            {
                _sumTime = value;
                NotifyPropertyChanged();
            }
        }
        #endregion


        #region ЗАДАЧА 2
        private string filename = AppDomain.CurrentDomain.BaseDirectory + "data.txt";
        private int linesNumber = 1000000;
        private int[] senselessDataNumbers;

        private string _fileLoadReport;
        private string _allEven;
        private string _all3n5Aliquots;
        private string _allPrimes;
        private string _allPowersOfTwo;
        private string _allEven_Time;
        private string _all3n5Aliquots_Time;
        private string _allPrimes_Time;
        private string _allPowersOfTwo_Time;

        public string FileLoadReport
        {
            get => _fileLoadReport;
            set
            {
                _fileLoadReport = value;
                NotifyPropertyChanged();
            }
        }
        public string AllEven
        {
            get => _allEven;
            set
            {
                _allEven = value;
                NotifyPropertyChanged();
            }
        }
        public string All3n5Aliquots
        {
            get => _all3n5Aliquots;
            set
            {
                _all3n5Aliquots = value;
                NotifyPropertyChanged();
            }
        }
        public string AllPrimes
        {
            get => _allPrimes;
            set
            {
                _allPrimes = value;
                NotifyPropertyChanged();
            }
        }
        public string AllPowersOfTwo
        {
            get => _allPowersOfTwo;
            set
            {
                _allPowersOfTwo = value;
                NotifyPropertyChanged();
            }
        }
        public string AllEven_Time
        {
            get => _allEven_Time;
            set
            {
                _allEven_Time = value;
                NotifyPropertyChanged();
            }
        }
        public string All3n5Aliquots_Time
        {
            get => _all3n5Aliquots_Time;
            set
            {
                _all3n5Aliquots_Time = value;
                NotifyPropertyChanged();
            }
        }
        public string AllPrimes_Time
        {
            get => _allPrimes_Time;
            set
            {
                _allPrimes_Time = value;
                NotifyPropertyChanged();
            }
        }
        public string AllPowersOfTwo_Time
        {
            get => _allPowersOfTwo_Time;
            set
            {
                _allPowersOfTwo_Time = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand FindAllEvenCommand { get => new DelegateCommand(FindAllEven_Start, CanReadArray); }
        public ICommand FindAll3n5AliquotsCommand { get => new DelegateCommand(FindAll3n5Aliquots_Start, CanReadArray); }
        public ICommand FindAllPrimesCommand { get => new DelegateCommand(FindAllPrimes_Start, CanReadArray); }
        public ICommand FindAllPowersOfTwoCommand { get => new DelegateCommand(FindAllPowersOfTwo_Start, CanReadArray); }
        public ICommand RecreateFileCommand { get => new DelegateCommand(RecreateFile, CanSetArray); }
        #endregion


        #region INTERFACE INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region INTERFACE IDataErrorInfo
        string IDataErrorInfo.Error => "некорректный ввод";
        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                if (columnName == "Input")
                {
                    if (Input == null) return null;
                    else if (!ulong.TryParse(Input, out inputNumber) || inputNumber < 0)
                    {
                        FactorialOutput = FactorialTime = null;
                        SumOutput = SumTime = null;
                        return "введите неотрицательное число";
                    }
                    else
                    {
                        if (inputNumber < 66) new Thread(ProcessFactorial) { IsBackground = true }.Start();
                        else
                        {
                            FactorialOutput = "слишком большое число (исчисляется от 0 до 65)";
                            FactorialTime = null;
                        }
                        new Thread(ProcessSumma) { IsBackground = true }.Start();
                        return null;
                    }
                }
                return null;
            }
        }
        #endregion


        public void ProcessFactorial()
        {
            var timer = Stopwatch.StartNew();
            ulong res = core.FactorialStart(inputNumber);
            timer.Stop();

            FactorialOutput = $"{_Input} !  =  {res}";
            FactorialTime = $"{timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks} тиков)";
        }

        public void ProcessSumma()
        {
            var timer = Stopwatch.StartNew();
            ulong res = core.Summa(inputNumber);
            timer.Stop();

            SumOutput = $"Σ {_Input}  =  {res}";
            SumTime = $"{timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks} тиков)";
        }


        public void OnLoad()
        {
            if (File.Exists(filename))
            {
                canReadArray = false;
                FileLoadReport = "файл загружается";

                var timer = Stopwatch.StartNew();
                var res = new List<int>(linesNumber);
                using var reader = new StreamReader(filename);
                while (!reader.EndOfStream)
                {
                    if (int.TryParse(reader.ReadLine(), out int temp)) res.Add(temp);
                }
                timer.Stop();
                senselessDataNumbers = res.ToArray();

                FileLoadReport = $"файл загружен ({timer.ElapsedMilliseconds} мс)";
                canReadArray = true;
                canSetArray = true;
            }
            else GenerateFile();
        }

        public void GenerateFile()
        {
            canReadArray = false;
            FileLoadReport = "файл создается";

            var timer = Stopwatch.StartNew();
            var random = new Random();
            string[] senselessData = new string[linesNumber];
            senselessDataNumbers = new int[linesNumber];

            for (int i = 0; i < linesNumber; i++)
            {
                senselessDataNumbers[i] = random.Next();
                senselessData[i] = senselessDataNumbers[i].ToString();
            }
            timer.Stop();

            FileLoadReport = $"файл создан ({timer.ElapsedMilliseconds} мс)";
            canReadArray = true;
            File.WriteAllLines(filename, senselessData);
        }

        public void RecreateFile(object parameter)
        {
            AllEven = AllEven_Time = null;
            All3n5Aliquots = All3n5Aliquots_Time = null;
            AllPrimes = AllPrimes_Time = null;
            AllPowersOfTwo = AllPowersOfTwo_Time = null;
            new Thread(GenerateFile).Start();
        }

        public bool CanReadArray(object nullparameter) => canReadArray;
        public bool CanSetArray(object nullparameter) => canReadArray && canSetArray;


        public void FindAllEven_Start(object parameter)
        {
            if (senselessDataNumbers != null)
                new Thread(FindAllEven_Process) { IsBackground = true }.Start();
            else throw new Exception("что-то пошло не так, файл не загружен и не создан");
        }
        public void FindAll3n5Aliquots_Start(object parameter)
        {
            if (senselessDataNumbers != null)
                new Thread(FindAll3n5Aliquots_Process) { IsBackground = true }.Start();
            else throw new Exception("что-то пошло не так, файл не загружен и не создан");
        }
        public void FindAllPrimes_Start(object parameter)
        {
            if (senselessDataNumbers != null)
                new Thread(FindAllPrimes_Process) { IsBackground = true }.Start();
            else throw new Exception("что-то пошло не так, файл не загружен и не создан");
        }
        public void FindAllPowersOfTwo_Start(object parameter)
        {
            if (senselessDataNumbers != null)
                new Thread(FindAllPowersOfTwo_Process) { IsBackground = true }.Start();
            else throw new Exception("что-то пошло не так, файл не загружен и не создан");
        }

        public void FindAllEven_Process()
        {
            canSetArray = false;
            var timer = Stopwatch.StartNew();
            int res = core.FindAllEven(senselessDataNumbers);
            timer.Stop();

            AllEven = $"{res}";
            AllEven_Time = $"{timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks} тиков)";
            canSetArray = true;
        }
        public void FindAll3n5Aliquots_Process()
        {
            canSetArray = false;
            var timer = Stopwatch.StartNew();
            int res = core.FindAll3n5Aliquots(senselessDataNumbers);
            timer.Stop();

            All3n5Aliquots = $"{res}";
            All3n5Aliquots_Time = $"{timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks} тиков)";
            canSetArray = true;
        }
        public void FindAllPrimes_Process()
        {
            canSetArray = false;
            var timer = Stopwatch.StartNew();
            int res = core.FindAllPrimes(senselessDataNumbers);
            timer.Stop();

            AllPrimes = $"{res}";
            AllPrimes_Time = $"{timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks} тиков)";
            canSetArray = true;
        }
        public void FindAllPowersOfTwo_Process()
        {
            canSetArray = false;
            var timer = Stopwatch.StartNew();
            int res = core.FindAllPowersOfTwo(senselessDataNumbers);
            timer.Stop();

            AllPowersOfTwo = $"{res}";
            AllPowersOfTwo_Time = $"{timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks} тиков)";
            canSetArray = true;
        }
        // public void FindAll_ProcessTemplate(Func<int[], int> method, ref string valueProperty, ref string timeProperty)
    }
}
