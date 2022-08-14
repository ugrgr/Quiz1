using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut
{
    internal class Polymorphism
    {

        class Employe
        {
    
            private int salary, hday, raise;
            private string job = "Çalışan", mark = new string('-', 6);
            public string name, surname;
            
            public int pSalary
            {
                get { return salary; }
                set { salary = value; }
            }
            public int pHday
            {
                get { return hday; }
                set { hday = value; }
            }
            public string pJob
            {
                get { return job; }
                set { job = value; }
            }
            public Employe()
            {
                this.name = null;
                this.surname = null;
                this.job = null;
                this.salary = 0;
                this.hday = 0;
            }
            public Employe(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
                this.job = "Stajyer";
                this.salary = 2900;
                this.hday = 7;
            }
            public Employe(string name, string surname, int salary)
            {
                this.name = name;
                this.surname = surname;
                this.salary = salary;
                this.job = createJob(salary);
                setHday();
            }
            public string createJob(int salary)
            {
                if (job.Contains("Çalışan") == true)
                {
                    if (salary >= 2900 && salary <= 3900)
                        return "Vasıfsız Çalışan";
                    else if (salary > 5900)
                        return "Uzman Çalışan";
                    else
                        return "Stajyer";
                }
                else if (job.Contains("Mühendis") == true)
                {
                    if (salary >= 5000 && salary <= 6000)
                        return "Mühendis";
                    else if (salary > 7000)
                        return "Uzman Mühendis";
                    else
                        return "Stajyer Mühendis";
                }
                else
                    return "Stajyer";
            }
            public void setHday()
            {
                if (job.Contains("Çalışan"))
                {
                    if (job.Contains("Uzman"))
                        hday = 28;
                    else
                        hday = 14;
                }
                else
                {
                    if (job.Contains("Uzman"))
                        hday = 35;
                    else
                        hday = 21;
                }
            }
            public void makeRaise(int value)
            {
                raise = salary;
                if (job.Contains("Mühendis"))
                {
                    salary += value;
                    salary = salary + Convert.ToInt32(salary * 0.1);
                    job = createJob(salary);
                    setHday();
                }
                else if (job.Contains("Çalışan"))
                {
                    salary += value;
                    job = createJob(salary);
                    setHday();
                }
            }
            public void infoBox()
            {
                Console.WriteLine("{0}\n< {1} Bilgileri >\n{2}\n-> Personel İsmi: {3}\n-> Personel Soyismi: {4}\n-> Görevi: {5}\n-> Maaşı: {6} TL\n-> İzin Günü: {7} Gün\n{8}"
                    , mark, job, mark, name, surname, job, salary, hday, mark);
            }
            public void raiseBox()
            {
                if (raise != 0)
                    Console.WriteLine("{0}\n < {1} Zam Uygulaması >\n{2}\n-> Personelin Eski Maaşı: {3} TL\n-> Yeni Verilecek Maaş: {4} TL\n{5}", mark, job, mark, raise, salary, mark);
            }
        }


    }
}