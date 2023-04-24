using System.Reflection;

namespace Hospital.UnitTests_
{
    [TestFixture]
    public class PatientTests
    {
        static Patient patient;

        [SetUp]
        public void Setup()
        {
            patient = new Patient("����", "������", "1378 6523 7060 5432");
            
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(patient.Name, Is.EqualTo("����"));
            Assert.That(patient.Surname, Is.EqualTo("������"));
            Assert.That(patient.PoliceNumber, Is.EqualTo("1378 6523 7060 5432"));
        }

        [Test]
        public void GetInfo_Patient_ValueString()
        {
            string expectedInfo = "���� ������. ";
            expectedInfo += "����� ������:1378 6523 7060 5432.";

            Assert.That(patient.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }

    [TestFixture]
    public class HospitalPatientTests
    {
        HospitalPatient man1;

        [SetUp]
        public void Setup()
        {
            man1 = new HospitalPatient("����", "������", "1378 6523 7060 5432", "���������������������", 105);

        }

        [Test] 
        public void ConstructorHPTest()
        { 
            Assert.That(man1.Department, Is.EqualTo("���������������������")); 
        }

        [Test] 
        public void GetInfoTest() 
        {
            var expected = "���� ������. " +
            $"����� ������:1378 6523 7060 5432." +
            "\n������� ���������� �� ��������������������� ���������.";
          
            Assert.That(man1.GetInfo(), Is.EqualTo(expected));
        }
    }

    public class DayHospitalPatientTests
    {
        DayHospitalPatient man2;

        [SetUp]
        public void Setup()
        {
            man2 = new DayHospitalPatient("����", "������", "1378 6523 7060 5432", DateTime.Parse("01.04.2023 12:00:00"), DateTime.Parse("01.04.2023 14:00:00"));

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
            var expected = "���� ������. " +
            $"����� ������:1378 6523 7060 5432." +
            "\n������� �������� ���������� ������ 01.04.2023 12:00:00." +
            "\n���� ����� 01.04.2023 14:00:00.";

            Assert.That(man2.GetInfo(), Is.EqualTo(expected));
        }
    }

    public class AmbulatoryPatientTests
    {
        AmbulatoryPatient man3;

        [SetUp]
        public void Setup()
        {
            man3 = new AmbulatoryPatient("����", "������", "1378 6523 7060 5432", "��������� ������� ����������");

        }

        [Test]
        public void ConstructorAPTest()
        {
            Assert.That(man3.DoctorInitials, Is.EqualTo("��������� ������� ����������"));
        }

        [Test]
        public void GetInfoTest()
        {
            var expected = "���� ������. " +
            $"����� ������:1378 6523 7060 5432." +
            "\n������������ ������� ������� � ��������� ������� ����������."; 
            
            Assert.That(man3.GetInfo(), Is.EqualTo(expected));
        }
    }
}