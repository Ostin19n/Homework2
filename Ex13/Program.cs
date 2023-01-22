// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(num);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра: " + anyNumberText[2]);
}
else {
  Console.WriteLine("Третья цифра отсутствует");
}
