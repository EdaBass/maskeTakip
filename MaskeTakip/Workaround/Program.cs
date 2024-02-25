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
            person1.FirstName = "Eda";
            person1.LastName = "Baş";
            person1.DateOfBirthYear = 1992;
            person1.NationalIdentity = 456;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }


    }

}

