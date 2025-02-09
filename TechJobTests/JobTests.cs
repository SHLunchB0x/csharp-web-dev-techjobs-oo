using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(Job.Equals(job1, job2));
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.AreEqual(job1.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job1.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job1.JobType.ToString(), "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.ToString(), "Persistence");
        }
        [TestMethod]
        public void TestForJobEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
    }
        [TestMethod]
        public void TestToString()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.ToString(), $"ID: {job1.Id} \n" +
                $"Name: {job1.Name}\n" +
                $"Employer:  {job1.EmployerName}\n" +
                $"Location: {job1.EmployerLocation}\n" +
                $"Position Type: {job1.JobType}\n" +
                $"Core Competency: {job1.JobCoreCompetency}");
        }
        [TestMethod]
        public void TestToStringEmptyField()
        {
            Job job1 = new Job();
            Assert.AreEqual(job1.ToString(), $"ID: {job1.Id} \n" +
                $"Name: Data not available\n" +
                $"Employer:  Data not available\n" +
                $"Location: Data not available\n" +
                $"Position Type: Data not available\n" +
                $"Core Competency: Data not available");
        }
    }
}
