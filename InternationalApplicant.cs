using System;

namespace Coursework_try2
{
    internal abstract class InternationalApplicant : Applicant, IApplicantActions
    {
        // Поля з доступом protected
        protected string countryOfOrigin;
        protected bool requiresEnglishProficiency;

        // Геттери та сеттери
        public string CountryOfOrigin
        {
            get { return countryOfOrigin; }
            set { countryOfOrigin = value; }
        }

        public bool RequiresEnglishProficiency
        {
            get { return requiresEnglishProficiency; }
            set { requiresEnglishProficiency = value; }
        }

        // Конструктор без аргументів делегує конструктору з аргументами
        public InternationalApplicant() : this(string.Empty, 0, string.Empty, 0.0, 0.0, 0.0, false, false, string.Empty, false)
        {
        }

        // Конструктор з аргументами
        public InternationalApplicant(
            string fullName,
            int age,
            string phoneNumber,
            double ukrScore,
            double mathScore,
            double historyScore,
            bool hasPrivilege,
            bool canPay,
            string countryOfOrigin,
            bool requiresEnglishProficiency)
            : base(fullName, age, phoneNumber, ukrScore, mathScore, historyScore, hasPrivilege, canPay)
        {
            this.countryOfOrigin = countryOfOrigin;
            this.requiresEnglishProficiency = requiresEnglishProficiency;
        }

        // Перевизначення віртуального методу DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Country of Origin: {countryOfOrigin}, Requires English Proficiency: {requiresEnglishProficiency}");
        }

        // Перевизначення віртуального методу IsEligible з інтерфейсу IApplicantActions
        public override bool IsEligible()
        {
            return base.IsEligible() && !requiresEnglishProficiency;
        }
    }
}
