using System.Reflection;
using static System.Collections.Specialized.BitVector32;

namespace Hospital.UnitTests_
{
    [TestFixture]
    public class PatientTests
    {
        static Patient patient;

        [SetUp]
        public void Setup()
        {
            patient = new Patient("Петр", "Иванов", 1378652370605432);
            
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(patient.Name, Is.EqualTo("Петр"));
            Assert.That(patient.Surname, Is.EqualTo("Иванов"));
            Assert.That(patient.PoliceNumber, Is.EqualTo(1378652370605432));
        }

        [Test]
        public void GetInfo_Patient_ValueString()
        {
            string expectedInfo = "Петр Иванов. ";
            expectedInfo += "Номер полиса:1378652370605432.";

            Assert.That(patient.GetInfo(), Is.EqualTo(expectedInfo));
        }

        [Test]
        public void CompareToTest()
        {
            var василий = new HospitalPatient("Василий", "Калинин", 2378752381606532, "физиотерапевтического", 105);

            var екатерина = new HospitalPatient("Екатерина", "Лебедева", 3478862392607632, "неврологического", 107);

            var олег = new HospitalPatient("Олег", "Кузнецов", 4578972353608732, "кардиологического", 115);

            Assert.That(василий.CompareTo(екатерина), Is.LessThan(0));
            Assert.That(олег.CompareTo(олег), Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class HospitalPatientTests
    {
        HospitalPatient man1;

        [SetUp]
        public void Setup()
        {
            man1 = new HospitalPatient("Петр", "Иванов", 1378652370605432, "физиотерапевтического", 105);

        }

        [Test] 
        public void ConstructorHPTest()
        { 
            Assert.That(man1.Department, Is.EqualTo("физиотерапевтического")); 
        }

        [Test] 
        public void GetInfoTest() 
        {
            var expected = "Петр Иванов. " +
            $"Номер полиса:{1378652370605432}." +
            "\nПациент стационара из физиотерапевтического отделения.";
          
            Assert.That(man1.GetInfo(), Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class DayHospitalPatientTests
    {
        DayHospitalPatient man2;

        [SetUp]
        public void Setup()
        {
            man2 = new DayHospitalPatient("Петр", "Иванов", 1378652370605432, DateTime.Parse("01.04.2023 12:00:00"), DateTime.Parse("01.04.2023 14:00:00"));

        }

        [Test]
        public void ConstructorDHPTest()
        {
            Assert.That(man2. ArrivalTime, Is.EqualTo(DateTime.Parse("01.04.2023 12:00:00")));
            Assert.That(man2.LeavingTime, Is.EqualTo(DateTime.Parse("01.04.2023 14:00:00")));
        }

        [Test]
        public void GetInfoTest()
        {
            var expected = "Петр Иванов. " +
            $"Номер полиса:{1378652370605432}." +
            "\nПациент дневного стационара пришел 01.04.2023 12:00:00." +
            "\nУшел домой 01.04.2023 14:00:00.";

            Assert.That(man2.GetInfo(), Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class AmbulatoryPatientTests
    {
        AmbulatoryPatient man3;

        [SetUp]
        public void Setup()
        {
            man3 = new AmbulatoryPatient("Петр", "Иванов", 1378652370605432, "Сафронова Дмитрия Романовича");

        }

        [Test]
        public void ConstructorAPTest()
        {
            Assert.That(man3.DoctorInitials, Is.EqualTo("Сафронова Дмитрия Романовича"));
        }

        [Test]
        public void GetInfoTest()
        {
            var expected = "Петр Иванов. " +
            $"Номер полиса:{1378652370605432}." +
            "\nАмбулаторный пациент лечится у Сафронова Дмитрия Романовича."; 
            
            Assert.That(man3.GetInfo(), Is.EqualTo(expected));
        }
    }

    [TestFixture]
    public class SectionTests
    {
        Section section;
        HospitalPatient[] hospitalPatients;

        [SetUp]
        public void Setup()
        {
            var василий = new HospitalPatient("Василий", "Калинин", 2378752381606532, "физиотерапевтического", 105);

            var екатерина = new HospitalPatient("Екатерина", "Лебедева", 3478862392607632, "неврологического", 107);

            var олег = new HospitalPatient("Олег", "Кузнецов", 4578972353608732, "кардиологического", 115);
            
            hospitalPatients = new HospitalPatient[] { василий, екатерина, олег };

            section = new Section("Первое", 3 , hospitalPatients);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(section.Title, Is.EqualTo("Первое"));
            Assert.That(section.PatientsQuantity, Is.EqualTo(3));
        }

        [Test]
        public void CountTest()
        {
            Assert.That(section.Count, Is.EqualTo(3));
        }

        [Test]
        public void IEnumerableTest()
        {
            var i = 0;

            foreach (var hospitalPatient in section)
                Assert.That(hospitalPatient, Is.SameAs(hospitalPatients[i++]));
        }
    }
}