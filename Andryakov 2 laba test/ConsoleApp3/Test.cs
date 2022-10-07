using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Test
    {
        public string Name_Lesson { get; set; }
        public bool Offset { get; set; }

        public Test (string name_Lesson, bool offset)
        {
            Name_Lesson = name_Lesson;
            Offset = offset;
        }
        public Test() 
        {
            Name_Lesson = "NO";
            Offset = false;
        }

        public override string ToString()
        {
            return Name_Lesson + " " + Offset.ToString();
        }

    }
}
