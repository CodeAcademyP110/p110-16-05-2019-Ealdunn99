using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();
            int num;
            bool ifyes=true;
            int i = 0;
            while (ifyes)
            {
                ifyes = !int.TryParse(name[i].ToString(), out num);
                if (ifyes == false)
                {
                    ifyes = true;
                    break;
                }
                if (i == name.Length - 1) { ifyes = false; }
                i++;
            }



            if (name.Length < 2 || name.IndexOf(" ") !=-1)
            {
                ifyes = true;
            }
            int tes=0;
            while (ifyes)
            {
                Console.WriteLine("Input a valid name");
                name = Console.ReadLine();
                 i = 0;
                while (ifyes)
                {
                    ifyes = !int.TryParse(name[i].ToString(), out num);
                    if (ifyes == false)
                    {
                       
                        tes = 1;
                    }
                    if (i == name.Length-1) { ifyes = false; }
                    i++;
                }
                if (tes == 1) { ifyes = true;tes = 0; }
                if (name.Length < 2 || name.IndexOf(" ") != -1)
                {
                    ifyes = true;
                }
            }


            Console.WriteLine("Please enter your last name:");
            string lastname = Console.ReadLine();
            int num2;
            bool ifyes2 = true;
             i = 0;
            while (ifyes2)
            {
                ifyes2 = !int.TryParse(lastname[i].ToString(), out num2);
                if (ifyes2 == false)
                {
                    ifyes2 = true;
                    break;
                }
                if (i == lastname.Length - 1) { ifyes2 = false; }
                i++;
            }


             tes = 0;
            while (ifyes2)
            {
                Console.WriteLine("Input a valid lastname");
                lastname = Console.ReadLine();
                i = 0;
                while (ifyes2)
                {
                    ifyes2 = !int.TryParse(lastname[i].ToString(), out num2);
                    if (ifyes2 == false)
                    {

                        tes = 1;
                    }
                    if (i == lastname.Length - 1) { ifyes2 = false; }
                    i++;
                }
                if (tes == 1) { ifyes2 = true; tes = 0; }
                if (lastname.Length < 2 || lastname.IndexOf(" ") != -1)
                {
                    ifyes2 = true;
                }
            }


           
            DateTime birthdate;
            while (true)
            {
                Console.WriteLine("Please enter your date of birth ( year.month.day):");
                try
                {
                    birthdate = Convert.ToDateTime(Console.ReadLine());
                    if (DateTime.Now.Year - birthdate.Year >0)
                    {
                        break;
                    }
                   

                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter your date of birth ( year.month.day):");
                }
            }

            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();
            int num3;
            bool ifyes3 = int.TryParse(email, out num3);
            if (email.Length < 2 || email.IndexOf(" ") != -1 || email.IndexOf("@") ==-1)
            {
                ifyes3 = true;
            }
            while (ifyes3)
            {
                Console.WriteLine("Input a valid email");
                email = Console.ReadLine();
                ifyes3 = int.TryParse(email, out num3);
                if (email.Length < 2 || email.IndexOf(" ") != -1 || email.IndexOf("@") == -1)
                {
                    ifyes3 = true;
                }
            }

            Student telebe1 = new Student(name, lastname, birthdate,email);
            Console.WriteLine("FullInfo :  ");
            Console.WriteLine(telebe1.Fullinfo());
            Console.WriteLine("ShortInfo :  ");
            Console.WriteLine(telebe1.info());

            #region for new birthdate 
            //Console.WriteLine("Please enter your New date of birth ( year.month.day):");
            //DateTime newbirthdate;
            //while (true)
            //{
            //    try
            //    {
            //        newbirthdate = Convert.ToDateTime(Console.ReadLine());
            //        break;

            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Please enter your New date of birth ( year.month.day):");
            //    }
            //}
            //telebe1.changeB(newbirthdate);
            //Console.WriteLine(telebe1.Fullinfo());
            #endregion

            #region for new email 
            //Console.WriteLine("Please enter your new email:");
            //string newemail = Console.ReadLine();

            // ifyes3 = int.TryParse(newemail, out num3);
            //if (newemail.Length < 2 || newemail.IndexOf(" ") != -1 || newemail.IndexOf("@") == -1)
            //{
            //    ifyes3 = true;
            //}
            //while (ifyes3)
            //{
            //    Console.WriteLine("Input a valid new email");
            //    newemail = Console.ReadLine();
            //    ifyes3 = int.TryParse(newemail, out num3);
            //    if (newemail.Length < 2 || newemail.IndexOf(" ") != -1 || newemail.IndexOf("@") == -1)
            //    {
            //        ifyes3 = true;
            //    }
            //}
            //telebe1.changeE(newemail);
            //Console.WriteLine(telebe1.Fullinfo());
            #endregion
        }
    }

    public class Student
    {

        public string Firstname;
        public string Lastname;
        private string Username;
        public DateTime Birthdate;
        public string Email;
        public int Age;

        public Student(string firstname, string lastname, DateTime birthdate) 
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = Firstname +" "+ Lastname;
            Birthdate = birthdate;
            Age = DateTime.Now.Year - birthdate.Year;
        }
        public Student(string firstname, string lastname, DateTime birthdate ,string email) : this( firstname,  lastname,  birthdate)
        {
            Email = email;
        }

        public string TellName()
        {
            return Username.ToLower();
        }
        public int TellAge()
        {
            return Age;
        }
        public string Fullinfo()
        {
            return $"{TellName()} { TellAge()} years old  {Email}";
        }
        public string info()
        {
            return $"{Firstname}{" "}{Lastname}";
        }
        public int changeB(DateTime newbirthdate)
        {
            Age = DateTime.Now.Year - newbirthdate.Year;


            return Age;
        }
        public string changeE(string newemail)
        {
            Email = newemail;
            return Email;
        }
    }
}
