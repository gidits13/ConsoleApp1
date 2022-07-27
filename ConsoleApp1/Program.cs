using System;

namespace SF_Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            

            Console.Write("Введите имя:\n");
            string name = Console.ReadLine();

            Console.Write("Сколько Вам лет?\n");
            //int age = int.Parse(Console.ReadLine());
            var age = Convert.ToByte(Console.ReadLine());

            Console.Write("Укажите дату рождения\n");
            var birtday = Console.ReadLine();

            Console.Write("Какой у Вас любимый день недели\n");
           // DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
           var day = (week)Convert.ToByte(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Ваше имя - {name}\nВозраст - {age}\nДень рождения - {birtday}\nЛюбимый день - {day}");

      
    }
    }
}
enum week : byte
{
    Понедельник=1,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Воскресенье
}