using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_try2
{
    internal abstract class Person : InternationalApplicant
    {
        // Поле з доступом protected
        protected string passportNumber;

        // Геттери та сеттери
        public string PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }

        // Конструктор без аргументів делегує конструктору з аргументами
        public Person() : this(string.Empty, 0, string.Empty, 0.0, 0.0, 0.0, false, false, string.Empty, false, string.Empty)
        {
        }

        // Конструктор з аргументами
        public Person(
            string fullName,
            int age,
            string phoneNumber,
            double ukrScore,
            double mathScore,
            double historyScore,
            bool hasPrivilege,
            bool canPay,
            string countryOfOrigin,
            bool requiresEnglishProficiency,
            string passportNumber)
            : base(fullName, age, phoneNumber, ukrScore, mathScore, historyScore, hasPrivilege, canPay, countryOfOrigin, requiresEnglishProficiency)
        {
            this.passportNumber = passportNumber;
        }

        // Перевизначення віртуального методу DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Passport Number: {passportNumber}");
        }
    }
}
