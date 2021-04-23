using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        // ! Foreach loop 
        // public Statistics GetStatistics()
        // {
        //     var result = new Statistics();
        //     result.Average = 0.0;
        //     result.High = double.MinValue;
        //     result.Low = double.MaxValue;

        //     foreach (var grade in grades)
        //     {
        //         result.High = Math.Max(grade, result.High);
        //         result.Low = Math.Min(grade, result.Low);
        //         result.Average += grade;
        //     }
        //     result.Average /= grades.Count;

        //     return result;
        // }

        // ! Do-while loop
        // public Statistics GetStatistics()
        // {
        //     var result = new Statistics();
        //     result.Average = 0.0;
        //     result.High = double.MinValue;
        //     result.Low = double.MaxValue;

        //     var index = 0;
        //     do
        //     {
        //         result.High = Math.Max(grades[index], result.High);
        //         result.Low = Math.Min(grades[index], result.Low);
        //         result.Average += grades[index];
        //         index += 1;
        //     } while(index < grades.Count);
            
        //         result.Average /= grades.Count;
            
        //     return result;
        // }

        // ! While loop
        // public Statistics GetStatistics()
        // {
        //     var result = new Statistics();
        //     result.Average = 0.0;
        //     result.High = double.MinValue;
        //     result.Low = double.MaxValue;

        //     var index = 0;
        //     while(index < grades.Count)
        //     {
        //         result.High = Math.Max(grades[index], result.High);
        //         result.Low = Math.Min(grades[index], result.Low);
        //         result.Average += grades[index];
        //         index += 1;
        //     } 
        //         result.Average /= grades.Count;
            
        //     return result;
        // }

        // ! For loop
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index = 0; index < grades.Count; index++)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            } 
                result.Average /= grades.Count;

                switch(result.Average)
                {
                    case var d when d >= 90.0:
                        result.Letter = 'A';
                        break;

                    case var d when d >= 80.0:
                        result.Letter = 'B';
                        break;

                    case var d when d >= 70.0:
                        result.Letter = 'C';
                        break;

                    case var d when d >= 60.0:
                        result.Letter = 'D';
                        break;

                    default:
                        result.Letter = 'F';
                        break;
                }
            
            return result;
        }
        private List<double> grades;
        public string Name;
    }
}