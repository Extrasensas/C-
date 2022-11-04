using System;

namespace Kitm
{
    class Program
    {
        static void Main()
        {
            Teacher myTeacher = new Teacher("Vanda");
            Teacher myTeacher2 = new Teacher("Lina");

            Human myHuman = new Human("Edvardas");
            Console.WriteLine(myHuman.ID);

            Student mokinys = new Student("Aurimas");
            Student mokinys2 = new Student("Algimantas");
            Student mokinys3 = new Student("Dovydas");
          
            mokinys.Teacher = myTeacher;




            Console.WriteLine(mokinys.Name);
            Console.WriteLine(mokinys.Teacher.Name);
            Console.WriteLine(mokinys2.Name);
            Console.WriteLine(mokinys3.Name);
            Console.WriteLine();


            Console.WriteLine("Iveskite skaiciu");
            string input = Console.ReadLine();
            _ = new Teacher(input);
            myTeacher.Teachkids();
            

        }
        
    }
}
