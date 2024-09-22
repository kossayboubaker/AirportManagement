// See https://aka.ms/new-console-template for more information
using AM.UI.Console;

Console.WriteLine("Hello, World!");

// Création d'un avion non initialisé et initialisation via propriétés
Plane plane = new Plane();
plane.PlaneId = 1;
plane.PlaneType = PlaneType.Boing;
plane.Capacity = 600;
plane.ManufactureDate = new DateTime(2024, 6, 12);
Console.WriteLine(plane);

// Utilisation du constructeur paramétré
Plane plane1 = new Plane(PlaneType.Airbus, 200, new DateTime(2015, 3, 20));
Console.WriteLine(plane1);

// Utilisation des initialiseurs d’objet
Plane plane3 = new Plane
{
    PlaneId = 3,
    PlaneType = PlaneType.Airbus,
    Capacity = 700,
    ManufactureDate = new DateTime(1999, 11, 8)
};
Console.WriteLine(plane3);

// Polymorphisme - Test des types Passenger, Staff et Traveller
Passenger passenger = new Passenger("John", "Doe", "P123456");
passenger.EmailAdress = "john.doe@example.com";
passenger.Birthdate = new DateTime(2000, 5, 15);

Staff staff = new Staff("Jane", "Doe", "S123456", "Pilot", 50000);
Traveller traveller = new Traveller("Bob", "Brown", "T987654", "Good Health", "French");

Console.WriteLine(passenger.GetPassengerType());  // "I am a passenger"
Console.WriteLine(staff.GetPassengerType());      // "I am a passenger and I am a Staff Member"
Console.WriteLine(traveller.GetPassengerType());  // "I am a Traveller"

// Test de CheckProfile
Console.WriteLine(passenger.CheckProfile("John", "Doe"));  // true
Console.WriteLine(passenger.CheckProfile("John", "Doe", "john.doe@example.com"));  // true
Console.WriteLine(passenger.CheckProfile("John", "Doe", "wrong.email@example.com"));  // false

// Test du calcul de l'âge avec passage par référence
int age = 0;
passenger.GetAge(passenger.Birthdate, ref age);
Console.WriteLine($"Age calculé (passage par référence): {age}");

// Test du calcul de l'âge en utilisant un objet Passenger (passage par référence)
passenger.GetAge(passenger);
Console.WriteLine($"Age du passager: {passenger.Age}");