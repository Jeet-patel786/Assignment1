﻿using System;

namespace SchoolCourses
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Description { get; set; }
        public string InstructorName { get; set; }
        public int NumberOfStudents { get; set; }

        public virtual string CourseType()
        {
            return "Base Course";
        }
    }

    public class DaytimeCourse : Course
    {
        public int SectionNumber { get; set; }
        public string BlockNumber { get; set; }
        public string CertificateID { get; set; }

        public override string CourseType()
        {
            return "Daytime";
        }
    }

    public class EveningCourse : Course
    {
        public string ContractorID { get; set; }
        public DateTime ContractEndDate { get; set; }

        public override string CourseType()
        {
            return "Evening";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaytimeCourse daytimeCourse = new DaytimeCourse
            {
                CourseName = "Advance C#",
                CourseCode = "CMSK0200",
                Description = "Advanced C# involves mastering complex concepts and techniques in the C# programming language, including generics, delegates, events, LINQ, asynchronous programming with async/await, and advanced OOP principles such as design patterns. It focuses on building efficient, scalable, and maintainable applications while leveraging .NET frameworks and libraries.",
                InstructorName = "Allan",
                NumberOfStudents = 30,
                SectionNumber = 1000787,
                BlockNumber = "11-532",
                CertificateID = "PP100-Y2"
            };

            Console.WriteLine($"Daytime Course: {daytimeCourse.CourseName}");
            Console.WriteLine($"Course Code: {daytimeCourse.CourseCode}");
            Console.WriteLine($"Description: {daytimeCourse.Description}");
            Console.WriteLine($"Instructor: {daytimeCourse.InstructorName}");
            Console.WriteLine($"Number of Students: {daytimeCourse.NumberOfStudents}");
            Console.WriteLine($"Section Number: {daytimeCourse.SectionNumber}");
            Console.WriteLine($"Block Number: {daytimeCourse.BlockNumber}");
            Console.WriteLine($"Certificate ID: {daytimeCourse.CertificateID}");
            Console.WriteLine($"Course Type: {daytimeCourse.CourseType()}");
            Console.WriteLine();

            EveningCourse eveningCourse = new EveningCourse
            {
                CourseName = "Introduction to angular",
                CourseCode = "CMSK0153",
                Description = "Angular is a powerful, open-source JavaScript framework developed by Google for building dynamic, single-page web applications. It uses TypeScript and provides features like two-way data binding, dependency injection, and a component-based architecture for creating scalable, responsive user interfaces.",
                InstructorName = "Allan",
                NumberOfStudents = 30,
                ContractorID = "CVEN-9982",
                ContractEndDate = new DateTime(2025, 12, 31)
            };

            Console.WriteLine($"Evening Course: {eveningCourse.CourseName}");
            Console.WriteLine($"Course Code: {eveningCourse.CourseCode}");
            Console.WriteLine($"Description: {eveningCourse.Description}");
            Console.WriteLine($"Instructor: {eveningCourse.InstructorName}");
            Console.WriteLine($"Number of Students: {eveningCourse.NumberOfStudents}");
            Console.WriteLine($"Contractor ID: {eveningCourse.ContractorID}");
            Console.WriteLine($"Contract End Date: {eveningCourse.ContractEndDate:yyyy-MM-dd}");
            Console.WriteLine($"Course Type: {eveningCourse.CourseType()}");
        }
    }
}
