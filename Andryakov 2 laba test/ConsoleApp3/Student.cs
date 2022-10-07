using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student : Person, IDateAndCopy
    {
        private Education educat;
        private int group;
        private Test[] test;
        private Exam[] exam;

        public Student(Education edu, int gr, Test[] te, Exam[] ex) { educat = edu; group = gr; test=te; exam = ex; }
       
        public Person Stud { get { return new Person(); } set { } }
        public Education Educat { get { return educat; } set { } }
        public int Group { get { return group; } set
            {
                try
                {
                    if (group <= 100 | group > 599)
                    {
                        group = value;
                    }
                }
                catch
                {
                    Console.WriteLine("Номер группы в диапазоне от 101 до 599");
                }
                
            } }
        public Exam[] Exam { get { return exam; } set { } }

        public double Average_Estimation { get => exam.Sum(x => x.estimation) / (double)exam.Count(); }


        public Student( Education educats, int groups)
        {
            educat = educats;
            group = groups;
            exam = new Exam[] { new Exam() };
        }

        public Student()
        {
            exam = new Exam[] { new Exam() };
        }

        public bool IsThatGrade(Education educatb)
        {
            return educat == educatb;
        }

        public void AddExams(params Exam[] exams)
        {
            if (exams.Length != 0)
            {
                exam = exam.Concat(exams).ToArray();
            }

        }

        public override string ToString()
        {
            return string.Join(" ",  educat, group, string.Join("\nExam: ", (IEnumerable<Exam>)exam));
        }
        public string ToShortString()
        {
            return string.Join(" ", educat, group, Average_Estimation);
        }

        public virtual Object DeepCopy()
        {
            return (new Student(this.educat, this.group, this.test, this.exam));
        }
        public IEnumerator<Exam> Getexam()
        {
            for (int i = 0; i < exam.Length; i++)
            {
                yield return exam[i];
            }
        }
        public IEnumerator<Exam> Getestimation()
        {
            for (int i = 0; i < exam.Length; i++)
            {
                if (exam[i].estimation>3)
                {
                    yield return exam[i];
                }
                
            }
        }
    }
}

