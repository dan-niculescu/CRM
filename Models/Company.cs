﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Company
    {
        public int CompanyId {get;set;}
        public string Name { get; set; }
        public string City {get;set;}
        public string CUI { get; set; }
        public string J { get; set; }
        public string Adress {get;set;}
        public string FieldOfActivity { get; set; }
        public bool PreviousContract { get; set; }
        public bool HasAutoPark { get; set; }
        public int NrOfDrivers { get; set; }
        public string ServicesOfInterest { get; set; } 
        public DateTime DateOfTheFirstContact { get; set; }
        public DateTime DateOfTheSecondContact { get; set; }
        public DateTime DateOfTheThirdContact { get; set; }
        public DateTime DateOfTheFourthContact { get; set; }
        public DateTime DateOfTheFifthContact { get; set; }
        public string Discution1 { get; set; }
        public string Discution2 { get; set; }
        public string Discution3 { get; set; }
        public string Discution4 { get; set; }
        public string Discution5 { get; set; }
        public string LongDiscutions { get; set; }
        public DateTime CallBackDate { get; set; }
        public string CourseLvl1 { get; set; }
        public string CourseLvl2 { get; set; }
        public string CourseLvl3 { get; set; }

        public List<ContactPerson> Persons {get;set;}
    }
}
