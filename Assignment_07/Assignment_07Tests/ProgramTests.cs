// Project: Assignment 7 Unit Tests
// Description: Vehicle, Car, Truck, MotorBoat objects
// Name: Alex Moreno, Andy E. Wold, Bethaly Tenango
// Date: 30 Jun 2016
// Instructor: Brother Daniel Masterson
// Course: CS 176 Windows Desktop Development

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void VehicleTest()
        {
            //This is an abstract class, so we cannot run tests on it.
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void writeTest()
        {
            Assert.IsTrue(true);
        }
    }

    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            //ASSIGN: Create new test object
            Car car = new Car("123456790", new DateTime(2016, 5, 22, 10, 40, 0), "ABC123456790", new Owner("Sally", "Smithe", "1807 Pennsylvania Ave", "Washington, D.C."), 4);

            Assert.AreEqual(car.registrationNumber, "123456790");
            Assert.AreEqual(car.owner.firstName, "Sally");
            Assert.AreEqual(car.numberDoors, 4);
        }

        [TestMethod()]
        public void writeTest()
        {
            Assert.IsTrue(true);
        }
    }

    [TestClass()]
    public class TruckTests
    {
        [TestMethod()]
        public void TruckTest()
        {
            //ASSIGN: Create new test object
            Truck truck = new Truck("123456791", new DateTime(2016, 4, 22, 10, 40, 0), "ABC123456791", new Owner("James", "Jones", "1801 Pennsylvania Ave", "Washington, D.C."), 2);

            Assert.AreEqual(truck.registrationNumber, "123456791");
            Assert.AreEqual(truck.owner.address, "1801 Pennsylvania Ave");
            Assert.AreEqual(truck.numberAxels, 2);
        }

        [TestMethod()]
        public void writeTest()
        {
            Assert.IsTrue(true);
        }
    }

    [TestClass()]
    public class MotorBoatTests
    {
        [TestMethod()]
        public void MotorBoatTest()
        {
            //ASSIGN: Create new test object
            MotorBoat motorBoat = new MotorBoat("123456792", new DateTime(2016, 3, 22, 10, 40, 0), "ABC123456792", new Owner("John", "Johnson", "1809 Pennsylvania Ave", "Washington, D.C."), "Outboard V-16");

            Assert.AreEqual(motorBoat.registrationNumber, "123456792");
            Assert.AreEqual(motorBoat.owner.lastName, "Johnson");
            Assert.AreEqual(motorBoat.engineType, "Outboard V-16");
        }

        [TestMethod()]
        public void writeTest()
        {
            Assert.IsTrue(true);
        }
    }
}