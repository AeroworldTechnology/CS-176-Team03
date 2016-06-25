// Project: Assignment 7
// Description: Vehicle, Car, Truck, MotorBoat objects
// Name: Alex Moreno, Andy E. Wold, Bethaly Tenango
// Date: 22 Jun 2016
// Instructor: Brother Daniel Masterson
// Course: CS 176 Windows Desktop Development

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("123456789", new DateTime(2016, 6, 22, 10, 40, 0), "ABC123456789", 1234, new Owner("Joe", "Smith", "1805 Pennsylvania Ave", "Washington, D.C."));

            for (int i = 0; i < 50; i++) { Write("_"); }
            WriteLine("\nVehicle properties:\n");
            vehicle.write();

            Car car = new Car("123456790", new DateTime(2016, 5, 22, 10, 40, 0), "ABC123456790", 1235, new Owner("Sally", "Smithe", "1807 Pennsylvania Ave", "Washington, D.C."), 4);

            for (int i = 0; i < 50; i++) { Write("_"); }
            WriteLine("\nCar properties:\n");
            car.write();

            Truck truck = new Truck("123456791", new DateTime(2016, 4, 22, 10, 40, 0), "ABC123456791", 1236, new Owner("James", "Jones", "1801 Pennsylvania Ave", "Washington, D.C."), 2);

            for (int i = 0; i < 50; i++) { Write("_"); }
            WriteLine("\nTruck properties:\n");
            truck.write();

            for (int i = 0; i < 50; i++) { Write("_"); }
            WriteLine();
            ReadLine();
        }
    }

    public class Vehicle
    {
        string registrationNumber = "";
        DateTime registrationDate = new DateTime(1900,1,1,0,0,0);
        string VIN = "";
        int internalID = 0;

        Owner owner;

        public Vehicle( string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner )
        {
            this.registrationNumber = registrationNumber;
            this.registrationDate = registrationDate;
            this.VIN = VIN;
            this.internalID = internalID;
            this.owner = owner;
        }

        public void write()
        {
            WriteLine("Registration Number: \t" + this.registrationNumber);
            WriteLine("Registration Date: \t" + this.registrationDate);
            WriteLine("VIN: \t\t\t" + this.VIN);
            WriteLine("Internal ID: \t\t" + this.internalID);
            WriteLine("First Name: \t" + this.owner.firstName);
            WriteLine("Last Name: \t" + this.owner.lastName);
            WriteLine("Address: \t" + this.owner.address);
            WriteLine("City: \t\t" + this.owner.city);
        }
    }

    public class Owner
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;

        //Constructor
        public Owner(string firstName, string lastName, string address, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
        }
    }

    public class Car:Vehicle
    {
        int numberDoors;

        //Constructor
        public Car(string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner, int numberDoors) : base(registrationNumber, registrationDate, VIN, internalID, owner)
        {
            this.numberDoors = numberDoors;
        }
    }

    public class Truck:Vehicle
    {
        int numberAxels;

        //Constructor
        public Truck(string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner, int numberAxels) : base(registrationNumber, registrationDate, VIN, internalID, owner)
        {
            this.numberAxels = numberAxels;
        }
    }

}
