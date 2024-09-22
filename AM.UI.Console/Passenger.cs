using System;
using System.Collections.Generic;

namespace AM.UI.Console
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAdress { get; set; }
        public List<Flight> Flights { get; set; }

        public Passenger(string firstName, string lastName, string passportNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PassportNumber = passportNumber;
        }

        // Propriété Age en lecture seule
        public int Age
        {
            get { return DateTime.Now.Year - Birthdate.Year; }
        }

        // Surcharge des méthodes CheckProfile
        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return CheckProfile(firstName, lastName) && EmailAdress == email;
        }

        public bool CheckProfile1(string firstName, string lastName, string email = null)
        {
            bool nameMatch = FirstName == firstName && LastName == lastName;
            return email == null ? nameMatch : nameMatch && EmailAdress == email;
        }

        // Méthode pour le polymorphisme par héritage
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }

        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Passport: {PassportNumber}";
        }

        // Méthodes pour calculer l'âge avec passage par valeur et référence
        public void GetAge(DateTime birthDate, ref int calculatedAge)
        {
            calculatedAge = DateTime.Now.Year - birthDate.Year;
        }

        public void GetAge(Passenger aPassenger)
        {
            aPassenger.Birthdate = new DateTime(DateTime.Now.Year - aPassenger.Age, aPassenger.Birthdate.Month, aPassenger.Birthdate.Day);
        }
    }
}
