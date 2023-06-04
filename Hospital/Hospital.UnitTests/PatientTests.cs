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
            patient = new Patient("����", "������", 1378652370605432);
            
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(patient.Name, Is.EqualTo("����"));
            Assert.That(patient.Surname, Is.EqualTo("������"));
            Assert.That(patient.PoliceNumber, Is.EqualTo(1378652370605432));
        }

        [Test]
        public void GetInfo_Patient_ValueString()
        {
            string expectedInfo = "���� ������. ";
            expectedInfo += "����� ������:1378652370605432.";

            Assert.That(patient.GetInfo(), Is.EqualTo(expectedInfo));
        }

        [Test]
        public void CompareToTest()
        {
            var ������� = new HospitalPatient("�������", "�������", 2378752381606532, "���������������������", 105);

            var ��������� = new HospitalPatient("���������", "��������", 3478862392607632, "����������������", 107);

            var ���� = new HospitalPatient("����", "��������", 4578972353608732, "�����������������", 115);

            Assert.That(�������.CompareTo(���������), Is.LessThan(0));
            Assert.That(����.CompareTo(����), Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class HospitalPatientTests
    {
        HospitalPatient man1;

        [SetUp]
        public void Setup()
        {
            man1 = new HospitalPatient("����", "������", 1378652370605432, "���������������������", 105);

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
            $"����� ������:{1378652370605432}." +
            "\n������� ���������� �� ��������������������� ���������.";
          
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
            man2 = new DayHospitalPatient("����", "������", 1378652370605432, DateTime.Parse("01.04.2023 12:00:00"), DateTime.Parse("01.04.2023 14:00:00"));

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
            $"����� ������:{1378652370605432}." +
            "\n������� �������� ���������� ������ 01.04.2023 12:00:00." +
            "\n���� ����� 01.04.2023 14:00:00.";

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
            man3 = new AmbulatoryPatient("����", "������", 1378652370605432, "��������� ������� ����������");

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
            $"����� ������:{1378652370605432}." +
            "\n������������ ������� ������� � ��������� ������� ����������."; 
            
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
            var ������� = new HospitalPatient("�������", "�������", 2378752381606532, "���������������������", 105);

            var ��������� = new HospitalPatient("���������", "��������", 3478862392607632, "����������������", 107);

            var ���� = new HospitalPatient("����", "��������", 4578972353608732, "�����������������", 115);
            
            hospitalPatients = new HospitalPatient[] { �������, ���������, ���� };

            section = new Section("������", 3 , hospitalPatients);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(section.Title, Is.EqualTo("������"));
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