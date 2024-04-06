class Program
{
    enum WeekDay
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    enum TimeOfDay
    {
        Ночь = 1,
        Утро,
        День,
        Вечер
    }

    static void Main(string[] args)
    {
        int dayInput;
        while (true)
        {
            Console.WriteLine("Введите номер дня недели (1-7):");

            if (int.TryParse(Console.ReadLine(), out dayInput) && dayInput > 0 && dayInput < 8) {
                break;
            }
            else {
                Console.WriteLine("Неправильный ввод!");
            }
        }

        int hourInput;
        while (true)
        {
            Console.WriteLine("Введите час (0-23):");
            if (int.TryParse(Console.ReadLine(), out hourInput) && hourInput > -1 && hourInput < 24)
            {
                break;
            }
            else
            {
                Console.WriteLine("Неправильный ввод!");
            }
        }
        TimeOfDay timeOfDay;

        if (hourInput >= 7 && hourInput <= 12) {
            timeOfDay = TimeOfDay.Утро;}
        else if (hourInput >= 13 && hourInput <= 18) {
            timeOfDay = TimeOfDay.День;}
        else if (hourInput >= 19 && hourInput <= 23) {
            timeOfDay = TimeOfDay.Вечер;}
        else timeOfDay = TimeOfDay.Ночь;

        string hourWord = "часов";
        if (new[] { 1, 21 }.Contains(hourInput)) {
            hourWord = "час";}
        else if (new[] { 2, 3, 4, 22, 23 }.Contains(hourInput)) { 
            hourWord = "часа"; }

        Console.WriteLine($"Сейчас {(WeekDay)dayInput}, {hourInput} {hourWord}, {timeOfDay.ToString()}.");
    }
}
