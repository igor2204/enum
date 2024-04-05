public class Program
{
    public enum DayWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum TimeDay
    {
        Morning,
        Day,
        Evening,
        Night
    }

    public static void Main()
    {
        Console.WriteLine("Введите день недели:");
        string inputDay = Console.ReadLine();
        DayWeek day = (DayWeek)Enum.Parse(typeof(DayWeek), inputDay);

        Console.WriteLine("Введите время:");
        int time = Convert.ToInt32(Console.ReadLine());
        if (time < 0 || time > 23)
        {
            Console.WriteLine("Ошибка: время должно быть от 0 до 23.");
        }
        else
        {
            TimeDay timeDay = OutTimeOfDay(time);
            Console.WriteLine($"Сейчас {day}, {timeDay}");
        }
    }

    public static TimeDay OutTimeOfDay(int time)
    {
        if (time >= 7 && time <= 12)
        {
            return TimeDay.Morning;
        }
        else if (time >= 13 && time <= 18)
        {
            return TimeDay.Day;
        }
        else if (time >= 19 && time <= 23)
        {
            return TimeDay.Evening;
        }
        else
        {
            return TimeDay.Night;
        }

    }
}
