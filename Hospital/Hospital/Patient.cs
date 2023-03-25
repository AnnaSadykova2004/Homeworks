using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly int PoliceNumber;
        public DateTime AdmissionDate;
        public DateTime DischargeDate;
        public Service Service;
        public int TreatmentCost;

        public Patient(string name, string surname, int policeNumber)
        {
            Name = name;
            Surname = surname;
            PoliceNumber = policeNumber;
        }

        public string GetInfo()
        {
            return $"{Name} {Surname}. Номер полиса:{PoliceNumber}.";
        }
    }
}
