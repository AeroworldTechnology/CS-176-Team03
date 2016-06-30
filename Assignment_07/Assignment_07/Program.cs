// Project: Assignment 7
// Description: Vehicle, Car, Truck, MotorBoat objects
// Name: Alex Moreno, Andy E. Wold, Bethaly Tenango
// Date: 30 Jun 2016
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
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Vehicle
    {
        //All variables/objects needed to be made public to allow access from other Classes
        public string registrationNumber = "";
        public DateTime registrationDate = new DateTime(1900,1,1,0,0,0);
        public string VIN = "";
        private int internalID = 0;

        public Owner owner;

        //public Vehicle(string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner)
        public Vehicle(string registrationNumber, DateTime registrationDate, string VIN, Owner owner)
        {
            this.registrationNumber = registrationNumber;
            this.registrationDate = registrationDate;
            this.VIN = VIN;
            //this.internalID = internalID;
            this.owner = owner;
        }

        // Forces each sub-class to inherit a write() method
        public abstract void write();
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
        public int numberDoors;

        //Constructor
        //public Car(string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner, int numberDoors) : base(registrationNumber, registrationDate, VIN, owner)
        public Car(string registrationNumber, DateTime registrationDate, string VIN, Owner owner, int numberDoors) : base(registrationNumber, registrationDate, VIN, owner)
        {
            this.numberDoors = numberDoors;
        }

        public override void write()
        {
            WriteLine("Registration Number: \t" + this.registrationNumber);
            WriteLine("Registration Date: \t" + this.registrationDate);
            WriteLine("VIN: \t\t\t" + this.VIN);
            WriteLine("First Name: \t" + this.owner.firstName);
            WriteLine("Last Name: \t" + this.owner.lastName);
            WriteLine("Address: \t" + this.owner.address);
            WriteLine("City: \t\t" + this.owner.city);
            WriteLine("Number of Doors: \t" + this.numberDoors);
        }
    }

    public class Truck:Vehicle
    {
        public int numberAxels;

        //Constructor
        //public Truck(string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner, int numberAxels) : base(registrationNumber, registrationDate, VIN, owner)
        public Truck(string registrationNumber, DateTime registrationDate, string VIN, Owner owner, int numberAxels) : base(registrationNumber, registrationDate, VIN, owner)
        {
            this.numberAxels = numberAxels;
        }

        public override void write()
        {
            WriteLine("Registration Number: \t" + this.registrationNumber);
            WriteLine("Registration Date: \t" + this.registrationDate);
            WriteLine("VIN: \t\t\t" + this.VIN);
            WriteLine("First Name: \t" + this.owner.firstName);
            WriteLine("Last Name: \t" + this.owner.lastName);
            WriteLine("Address: \t" + this.owner.address);
            WriteLine("City: \t\t" + this.owner.city);
            WriteLine("Number of Axels: \t" + this.numberAxels);
        }
    }

    public class MotorBoat:Vehicle
    {
        public string engineType;

        //Constructor
        //public MotorBoat(string registrationNumber, DateTime registrationDate, string VIN, int internalID, Owner owner, string engineType) : base(registrationNumber, registrationDate, VIN, owner)
        public MotorBoat(string registrationNumber, DateTime registrationDate, string VIN, Owner owner, string engineType) : base(registrationNumber, registrationDate, VIN, owner)
        {
            this.engineType = engineType;
        }

        public override void write()
        {
            WriteLine("Registration Number: \t" + this.registrationNumber);
            WriteLine("Registration Date: \t" + this.registrationDate);
            WriteLine("VIN: \t\t\t" + this.VIN);
            WriteLine("First Name: \t" + this.owner.firstName);
            WriteLine("Last Name: \t" + this.owner.lastName);
            WriteLine("Address: \t" + this.owner.address);
            WriteLine("City: \t\t" + this.owner.city);
            WriteLine("Engine Type: \t\t" + this.engineType);
        }
    }
}
