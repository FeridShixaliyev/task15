using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp45
{
    class Student
    {
        public int No { get; set; }
        public string Name { get; set; }

        Dictionary<string, int> Exams = new Dictionary<string, int>();
        

        public void AddExam(string examName,int point)
        {
            if(!string.IsNullOrWhiteSpace(examName))
            Exams.Add(examName, point);
        }
        public int GetExamResult(string examName)
        {
            if (!string.IsNullOrWhiteSpace(examName))
            {
                return Exams[examName];
            }
            return -1;
        }
        public int GetExamAvg()
        {
            int avg=0;
            foreach (var value in Exams.Values)
            {
                avg += value;
            }
            return avg / (Exams.Values.Count);
        }
    }
}
