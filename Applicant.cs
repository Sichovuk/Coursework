using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_try2
{
    // Власний інтерфейс для дій з аплікантами
    internal interface IApplicantActions
    {
        void DisplayInfo();
        bool IsEligible();
    }

    internal class Applicant : IComparable<Applicant>, IApplicantActions
    {
        // Приватні поля
        private string fullName;
        private int age;
        private string phoneNumber;
        private double ukrScore;
        private double mathScore;
        private double historyScore;
        private bool hasPrivilege;
        private bool canPay;

        // Геттери та сеттери
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public double UkrScore
        {
            get { return ukrScore; }
            set { ukrScore = value; }
        }

        public double MathScore
        {
            get { return mathScore; }
            set { mathScore = value; }
        }

        public double HistoryScore
        {
            get { return historyScore; }
            set { historyScore = value; }
        }

        public bool HasPrivilege
        {
            get { return hasPrivilege; }
            set { hasPrivilege = value; }
        }

        public bool CanPay
        {
            get { return canPay; }
            set { canPay = value; }
        }

        // Властивості для методів
        public bool IsAdult
        {
            get { return age >= 18; }
        }

        public double AverageScore
        {
            get { return (ukrScore * 0.3) + (mathScore * 0.5) + (historyScore * 0.2); }
        }

        public bool PassedNMT
        {
            get { return ukrScore > 99 && mathScore > 99 && historyScore > 99; }
        }

        public bool HasPassingScore
        {
            get { return AverageScore > 150; }
        }

        // Конструктор без аргументів делегує конструктору з аргументами
        public Applicant() : this(string.Empty, 0, string.Empty, 0.0, 0.0, 0.0, false, false)
        {
        }

        // Конструктор з аргументами
        public Applicant(string fullName, int age, string phoneNumber, double ukrScore, double mathScore, double historyScore, bool hasPrivilege, bool canPay)
        {
            this.fullName = fullName;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.ukrScore = ukrScore;
            this.mathScore = mathScore;
            this.historyScore = historyScore;
            this.hasPrivilege = hasPrivilege;
            this.canPay = canPay;
        }

        // Реалізація віртуального методу IsEligible з інтерфейсу IApplicantActions
        public virtual bool IsEligible()
        {
            return AverageScore >= 150;
        }

        // Статичний метод для перевантаження (статичний поліморфізм)
        public bool IsEligible(double additionalScore)
        {
            return (AverageScore + additionalScore) >= 150;
        }

        // Реалізація інтерфейсу IComparable<Applicant>
        public int CompareTo(Applicant other)
        {
            if (other == null) return 1;

            // Порівняння за середнім балом
            return AverageScore.CompareTo(other.AverageScore);
        }

        // Віртуальний метод для відображення інформації
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Applicant: {FullName}, Age: {Age}, Phone: {PhoneNumber}, Average Score: {AverageScore}");
        }
    }
}
