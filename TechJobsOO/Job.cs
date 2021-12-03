using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public Job()
        {
            Id = nextId++;
            //No idea if this is right
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency): this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            string id = $"{Id}";
            string name = $"{Name}";
            string employerName = $"{EmployerName}";
            string employerLocation = $"{EmployerLocation}";
            string positionType = $"{JobType}";
            string jobCoreCompetency = $"{JobCoreCompetency}";
            if (String.IsNullOrEmpty(name))
            {
                name = "Data not available";
            }
            if (String.IsNullOrEmpty(employerName))
            {
                employerName = "Data not available";
            }
            if (String.IsNullOrEmpty(employerLocation))
            {
                employerLocation = "Data not available";
            }
            if (String.IsNullOrEmpty(positionType))
            {
                positionType = "Data not available";
            }
            if (String.IsNullOrEmpty(jobCoreCompetency))
            {
                jobCoreCompetency = "Data not available";
            }
            return $"ID: {Id} \n" +
                $"Name: {name}\n" +
                $"Employer:  {employerName}\n" +
                $"Location: {employerLocation}\n" +
                $"Position Type: {positionType}\n" +
                $"Core Competency: {jobCoreCompetency}";
        }

        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
