using System;


namespace Задание_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Слистина Екатерина Владимировна";
            byte age = 37;
            string email = "slistina@bk.ru";
            double prog = 85.4;
            double matem = 95.2;
            double phis = 89.9;

            double summaball = prog + matem + phis;
           
            long GPA = (long) summaball / 3;

            string pattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} ";



            Console.WriteLine(pattern,
            FullName,
            age,
            email,
            prog,
            matem,
            phis);

            Console.ReadKey();
            
            
           string pattern1 = " \nСредний балл:{0}";
           Console.WriteLine(pattern1,
           GPA);

           Console.ReadKey();

        }
    }
}
