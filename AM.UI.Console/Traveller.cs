using System;

namespace AM.UI.Console
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public Traveller(string firstName, string lastName, string passportNumber, string healthInfo, string nationality)
            : base(firstName, lastName, passportNumber)
        {
            HealthInformation = healthInfo;
            Nationality = nationality;
        }

        public override string GetPassengerType()
        {
            return "I am a Traveller";
        }
    }
}
