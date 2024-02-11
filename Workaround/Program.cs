
using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Deniz";
            person1.LastName = "Yalçınkaya";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        

    }
}