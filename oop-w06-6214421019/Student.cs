using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w06
{
    class Student
    {
        private string name;
        private string id;
        private Subject[] subjects = new Subject[20];
        private int countSub = 0;
       
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public Student() { }
        public Student(string i,string n)
        {
            this.Id = i;
            this.Name = n;
        }
        public string detail()
        {
            return "StudentId: "+this.Id + " StudentName: "+ this.Name;
        }
        public void setSubject(int index,Subject s)
        {
            this.subjects[index] = s;
            this.countSub++;
        }
        public Subject getSubject(int index)
        {
            return this.subjects[index];
        }
        public int countSubject()
        {
            return this.countSub;
        }
        public int getAllUnit() {
            int sumUnit = 0;
            for(int i = 0; i < subjects.Length; i++)
            {
                if (this.subjects[i] != null)
                {
                    sumUnit+=this.subjects[i].getUnit();
                }
            }
            return sumUnit;
                }
        
    }
}
