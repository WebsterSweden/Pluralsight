using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            //name = name;
            this.name = name;

            //List<double> grades = new List<double>();
            grades = new List<double>();
        }

        public void ShowStatistics()
        {
            var averageGrade = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                averageGrade += number;
            }

            averageGrade = averageGrade / grades.Count;

            Console.WriteLine($"lowGrade {lowGrade}");
            Console.WriteLine($"highGrade {highGrade}");
            Console.WriteLine($"averageGrade {averageGrade}");

            //throw new NotImplementedException();
        }

        //public double AddGrade(double gradeParameter)
        //{
        //    double grade = gradeParameter;
        //    return grade;
        //}

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine(grades[0] + name);
        }

        //public List<double> grades;
        private List<double> grades;

        private string name;

        //List<double> grades = new List<double>();
        //List<double> grades;
    }
}
