//однострочный коментарий
//для многострочного коменнтирования выделяем строки для комментария и нажимаем "контрол + правый слэш"
//или /*коментарий*/

// int number = 9;
// int result = numder * number;
// "привет" + "мир" = "привет мир" - конкатенация
// Console.ReadLine(); - получить информацию из строчки


// Console.WriteLine("Введите число");              //  Вывод сообщения 

// int input = Convert.ToInt32(Console.ReadLine()); //  int - число, string - строка. convert.toInt32 - конвертация в числовой метод. 
//                                                  //  console.readle - получение информации из введенной строчки

// Console.WriteLine(input + 1000);                 //  вывод результата сложения переменной input  + 1000

Console.Write("Введи первое число: ");                //a
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");                //b
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber == secondNumber * secondNumber)      // "=" - придание значения, "==" - проверка равно/неравно
{
    Console.WriteLine("Да, " +firstNumber+ " является квадратом от числа " +secondNumber);
}
else                                                // если число а не является квадратом от числа b
{
    Console.WriteLine("Нет, " +firstNumber+ " НЕ является квадратом от числа " +secondNumber);
}