/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите цифру, обозначающую день недели,где 1 - Понедельник,2 - Вторник, 3 - Среда, 4 - Четверг, 5- Пятница, 6 - суббота, 7 - Воскресенье: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("В этот день можно поспать подольше,ведь сегодня выходной!");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Прочитайте условие еще раз.и попробуйте снова! :)");
  }
  else Console.WriteLine("В этот  день Вам нужно в садик/школу или на работу,и плевать какого Вы пола и какая погода на улице, ведь сегодня рабочий день!");
}

CheckingTheDayOfTheWeek(dayNumber);
