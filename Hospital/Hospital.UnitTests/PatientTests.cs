namespace Hospital.UnitTests
{
    [TestFixture]
    public class PatientTests
    {
       static Patient patient;

        [SetUp]
        public void Setup()
        {
            patient = new Patient("Peter", "Ivanov", 1378652370605432);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(patient.Name, Is.EqualTo("Peter"));
            Assert.That(patient.Surname, Is.EqualTo("Ivanov"));
            Assert.That(patient.PoliceNumber, Is.EqualTo(1378652370605432)); 
        }

        [Test]
        public void GetInfo_Patient_ValueString()
        {
            string expectedInfo = "Peter Ivanov. ";
            expectedInfo += "Номер полиса: 1378652370605432.";

            Assert.That(patient.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}