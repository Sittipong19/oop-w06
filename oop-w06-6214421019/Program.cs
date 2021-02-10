using System;

namespace oop-6214421017-w06
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("6214421017", "Rungrat Sriwirun");
            Console.WriteLine("_____________________________________________________________");
            s1.setSubject(0, new Subject("  0001301  ", "	  Chinese for Communication",3));
            s1.setSubject(1, new Subject("0002312", "	  Accounting in Daily Life",3));
           s1.setSubject(2, new Subject("9012051  ", "	  Operating Systems",3));
            s1.setSubject(3, new Subject("  9012061  ", "Data Communications and Computer Networks",3));
           s1.setSubject(4, new Subject("9022081", "Object Oriented Programming",3));
           s1.setSubject(5, new Subject("  9022132", "Web Programming",3));
            Console.WriteLine(s1.detail()+" learn "+s1.countSubject()+" subjects in term 2 and equal: "+s1.getAllUnit()+" Units");
            Lecuterer t1 = new Lecuterer("Nitat", "Ninchawee");
            t1.setSubject(0, new Subject("9022081", "Object Oriented Programming", 3));
            t1.setSubject(0, new Subject(2, 2));
            t1.setSubject(1, new Subject("  9022132", "Web Programming", 3));
            t1.setSubject(1, new Subject(2, 2));
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("teacherName: " + t1.FirstName + " " + t1.LastName +" teach: "+t1.counts()+" subject and "+t1.getHourteachPerWeek()+" hour per week");
        }
    }
}
