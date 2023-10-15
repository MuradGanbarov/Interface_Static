//using System.Text.RegularExpressions;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using Task_Interface_Static.Interfaces;

//namespace Task_Interface_Static
//{
//    public class Student : ICodeAcademy
//    {
//        static int Count = 0;
//        public int Id { get; }
//        public string Name { get; }
//        public string Surname { get; }
//        public string CodeEmail { get; set; }


//        public Student(string name, string surname)
//        {
//            if (CheckName(name))
//            {
//                Name = name;
//                Surname = surname;
//                Id = Count++;
//                CodeEmail = GenerateEmail();
//            }

//        }



//        public static bool CheckName(string name)
//        {
//            if (name.Length < 3 || name.Length > 25)
//            {
//                return false;
//            }


//            else
//            {
//                Console.WriteLine("Name and Surname is true");
//            }

//            return Regex.IsMatch(name, "^[a-zA-Z]+$");

//        }

//        public string GenerateEmail()
//        {
//            string emailName = $"{Name.ToLower()}.{Surname.ToLower()}{Id}";
//            return $"{emailName}@code.edu.az";
//        }



//    }
//}
