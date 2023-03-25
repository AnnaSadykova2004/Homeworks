namespace Hospital.UnitTests_
{
    [TestFixture]
    public class PersonTests
    {
        static Patient patient;

        [SetUp]
        public void Setup()
        {
            patient = new Patient("Peter", "Ivanov", "1378 6523 7060 5432");
        }

        [Test]
        public void ConstructotTest()
        {
            Assert.That(patient.Name, Is.EqualTo("Peter"));
            Assert.That(patient.Surname, Is.EqualTo("Ivanov"));
            Assert.That(patient.PoliceNumber, Is.EqualTo("1378 6523 7060 5432"));
        }

        [Test]
        public void GetInfo_Patient_ValueString()
        {
            string expectedInfo = "Peter Ivanov. ";
            expectedInfo += "Номер полиса: 1378 6523 7060 5432.";

            Assert.That(patient.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}