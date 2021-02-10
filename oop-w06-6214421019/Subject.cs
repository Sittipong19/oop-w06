using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421019-w06
{
    class Subject
    {
        private string code;
        private string name;
        private int unit;
        private int lecture;
        private int lab;


        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Unit { get => unit; set => unit = value; }
        public int Lecture { get => lecture; set => lecture = value; }
        public int Lab { get => lab; set => lab = value; }

        public Subject() { }
        public Subject(string c,string n,int u)
        {
            this.Code = c;
            this.Name = n;
            this.Unit = u;
        }

        public Subject(int lect,int lab)
        {
            this.Lab = lab;
            this.Lecture = lect;
        }
        public int getUnit()
        {
            return this.Unit;
        }
        public int getLecture()
        {
            return this.Lecture;
        }
        public int getLab()
        {
            return this.Lab;
        }
        
    }
}
