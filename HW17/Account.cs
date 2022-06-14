using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    class Account<T>
    {
        private T number;
        private string fio;
        private double balance;

        public string GetInfo()
        {
            return $"{number} {fio} {balance}";
        }

        public void SetInfo()
        {
            Console.WriteLine("Введите номер");
            string stringnumber = Console.ReadLine();
            number = (T)Convert.ChangeType(stringnumber, typeof(T));

            Console.WriteLine("Введите ФИО");
            fio = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            balance = Convert.ToInt32(Console.ReadLine());
        }

        /*public void Input()
        {
            Console.WriteLine("Введите номер");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите зп");
            Summa = Convert.ToInt32(Console.ReadLine());
        }*/
    }
}
