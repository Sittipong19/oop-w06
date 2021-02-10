using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w06
{
    class Lecuterer
    {
        private string firstName;
        private string lastName;
        private Subject[] subject = new Subject[7];
        private int countS = 0;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public Lecuterer() { }
        public Lecuterer(string f,string l)
        {
            this.FirstName = f;
            this.LastName = l;
        }
        public void setSubject(int index,Subject s)
        {
            this.subject[index] = s;
            this.countS++;

        }
        public Subject getSubjects(int index)
        {
            return this.subject[index];
        }
        public int getHourteachPerWeek()
        {
            int totalHour = 0;
            for(int k = 0; k < subject.Length; k++)
            {
                if (this.subject[k] != null) { 
                totalHour += this.subject[k].getLecture()+ this.subject[k].getLecture();
                    
                        }
            }
            return totalHour;
        }
        public int counts()
        {
            return this.countS/2;
        }
        
    }
}
