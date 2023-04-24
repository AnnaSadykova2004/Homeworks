using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string PoliceNumber;
        public DateTime AdmissionDate;
        public DateTime DischargeDate;
        public Service Service;
        public int TreatmentCost;

        public Patient(string name, string surname, string policeNumber)
        {
            Name = name;
            Surname = surname;
            PoliceNumber = policeNumber;
        }
        public virtual string GetInfo()
        {
           return $"{Name} {Surname}. Номер полиса:{PoliceNumber}.";
        }
    }
    public class HospitalPatient : Patient 
    {
        public string Department { get; set; }
        public int RoomNumber { get; set; }

        public HospitalPatient(string name, string surname, string policeNumber, string department, int roomNumber) : base(name, surname, policeNumber)
        {
            Department = department;
            RoomNumber = roomNumber;
        }

        public override string GetInfo() => base.GetInfo() +
        $"\nПациент стационара из {Department} отделения.";
    }
    public class DayHospitalPatient : Patient 
    {
        public DateTime ArrivalTime { get; set; }
        public DateTime LeavingTime { get; set; }

        public DayHospitalPatient(string name, string surname, string policeNumber, DateTime arrivalTime, DateTime leavingTime) : base(name, surname, policeNumber)
        {
            ArrivalTime = arrivalTime;
            LeavingTime = leavingTime;
        }

        public override string GetInfo() => base.GetInfo() +
        $"\nПациент дневного стационара пришел {ArrivalTime}." +
        $"\nУшел домой {LeavingTime}.";
    }
    public class AmbulatoryPatient : Patient
    {
        public string DoctorInitials { get; set; }
        
        public AmbulatoryPatient(string name, string surname, string policeNumber, string doctorInitials) : base(name, surname, policeNumber)
        {
            DoctorInitials = doctorInitials;
        }

        public override string GetInfo() => base.GetInfo() +
        $"\nАмбулаторный пациент лечится у {DoctorInitials}.";
    }
}
