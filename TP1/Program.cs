using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debut du programme");
            string saisie, name, first, promo, date;

            /*Student s = new Student("Jalil", "Zog", 24, new DateTime(1997, 01, 23));
            Console.WriteLine(s.ToString());
            */

            /*Console.WriteLine("Création d'un étudiant");
            

            Console.WriteLine("Saissez un prenom et un nom");
            saisie = Console.ReadLine();
            name = saisie.Split(' ')[0];
            first = saisie.Split(' ')[1];

            Console.WriteLine("Saisissez promo et DD/MM/YY");
            saisie = Console.ReadLine();
            promo = saisie.Split()[0];
            date = saisie.Split()[1];

            s = new Student(first, name, Int32.Parse(promo), DateTime.Parse(date));
            Console.WriteLine(s.ToString());
             */


            List<Student> students = new List<Student>();
            var rand = new Random();
            for (int i=0; i<30; i++)
            {
                first = "pren°" + i;
                name = "nom" + i;
                students.Add(new Student(first, name, i, new DateTime(1900 + rand.Next(100), rand.Next(11)+1, rand.Next(25) + 1) ));
            }

            foreach(Student i in students)
            {
                Console.WriteLine(i.ToString());
            }

            /*
            // Tri par date:

            students.Sort((x, y) => x.birthDate.CompareTo(y.birthDate));

            foreach (Student i in students)
            {
                Console.WriteLine(i.ToString());
            }

            // Tri par nom

            Console.WriteLine("\nTri par nom:");
            students.Sort((x, y) => x.firstName.CompareTo(y.firstName));
            foreach (Student i in students)
            {
                Console.WriteLine(i.ToString());
            }

            //Version 2:
            Console.WriteLine("\nTri par nom 2:");
            students.OrderBy(x => x.lastName);
            foreach (Student i in students)
            {
                Console.WriteLine(i.ToString());
            }*/

            /* Création du cours via console
             Affichage via la console
             Associer Students a un cours via la console*/

            Lecture cours = new Lecture();

            Console.WriteLine("Nom du cours ?");
            cours.name = Console.ReadLine();
            cours.salle = new List<string>();

            do
            {
                Console.WriteLine("Salle du cours ?");
                saisie = Console.ReadLine();
                cours.salle.Add(saisie);
                Console.WriteLine("D'autres salle ?");
            } while (Console.ReadLine() != "n");

            
            /*Console.WriteLine("Nom du professeur ?");*/
            Personne p = new Personne();
            p.firstName = "T";
            p.lastName = "cheur";

            List<Student> recup = new List<Student>();
            while(Console.ReadLine() == "y")
            {
                Console.WriteLine("Saisir n° etudiant [1,25]");
                recup.Add( students.ElementAt(Int32.Parse(Console.ReadLine())));

            }
            /*cours.name = Console.ReadLine();*/

            foreach (Student i in recup)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}
