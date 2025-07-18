using ScholarshipManagement2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipManagement2.Entities
{
    public class Student
    {
        int id;
        int age;
        string name;
        string email;
        StudentModel model;
        ScholarshipType type;
        decimal totalFee;
        decimal labFee;
        decimal libraryFee;
        decimal thesisFee;
        decimal courseMaterialFee;
        decimal technologyCharges;
        decimal recurringCharges;
        decimal netFee;

        public Student() { }

        public Student(int id, int age, string name, string email, StudentModel model, ScholarshipType type, decimal totalFee)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.email = email;
            this.model = model;
            this.type = type;
            this.totalFee = totalFee;
        }

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public StudentModel Model { get => model; set => model = value; }
        public ScholarshipType Type { get => type; set => type = value; }
        public decimal TotalFee { get => totalFee; set => totalFee = value; }
        public decimal LabFee { get => labFee; set => labFee = value; }
        public decimal LibraryFee { get => libraryFee; set => libraryFee = value; }
        public decimal ThesisFee { get => thesisFee; set => thesisFee = value; }
        public decimal CourseMaterialFee { get => courseMaterialFee; set => courseMaterialFee = value; }
        public decimal TechnologyCharges { get => technologyCharges; set => technologyCharges = value; }
        public decimal RecurringCharges { get => recurringCharges; set => recurringCharges = value; }
        public decimal NetFee {  get => netFee; set => netFee = value; }
    }
}
