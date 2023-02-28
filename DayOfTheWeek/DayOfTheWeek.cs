// Задача с днями недели 1-е решение:
int day = 6;
if (day == 1) Console.WriteLine("Пн");
else if (day == 2) Console.WriteLine("Вт");
else if (day == 3) Console.WriteLine("Ср");
else if (day == 4) Console.WriteLine("Чт");
else if (day == 5) Console.WriteLine("Пт");
else if (day == 6) Console.WriteLine("Сб");
else if (day == 7) Console.WriteLine("Вс");
if (day == 6) {
    Console.WriteLine("Данным днём является суббота и она выходной");
}
else if (day == 7) {
    Console.WriteLine("Данным днём является воскресенье и это выходной день.");
}

// Задача с днями недели 2-е решение:
int day = 6;
if(day>=6 && day<=7)
{
    if (day == 6){
        Console.WriteLine("Данным днём является суббота и это выходной день");
    }
    else {
        Console.WriteLine("Данным днём является воскресенье и это выходной день");
    }
}
else {
    Console.WriteLine("Данный день не является выходным");
}