Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
{
Console.WriteLine("(Это выходной день) -> да");
}
  else if (dayNumber < 1 || dayNumber > 7) 
{
Console.WriteLine("Это вообще не день недели");
}
  else Console.WriteLine("(Это выходной?) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
