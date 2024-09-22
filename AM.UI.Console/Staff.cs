using System;

namespace AM.UI.Console
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        public float Salary { get; set; }

        public Staff(string firstName, string lastName, string passportNumber, string function, float salary)
            : base(firstName, lastName, passportNumber)
        {
            EmploymentDate = DateTime.Now;
            Function = function;
            Salary = salary;
        }

        public override string GetPassengerType()
        {
            return "I am a passenger and I am a Staff Member";
        }
    }
}
