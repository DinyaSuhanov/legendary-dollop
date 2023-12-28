// //однострочный коментарий
// //для многострочного коменнтирования выделяем строки для комментария и нажимаем "контрол + правый слэш"
// //или /*коментарий*/

// // int number = 9;
// // int result = numder * number;
// // "привет" + "мир" = "привет мир" - конкатенация
// // Console.ReadLine(); - получить информацию из строчки


// // Console.WriteLine("Введите число");              //  Вывод сообщения

// // int input = Convert.ToInt32(Console.ReadLine()); //  int - число, string - строка. convert.toInt32 - конвертация в числовой метод.
// //                                                  //  console.readle - получение информации из введенной строчки

// // Console.WriteLine(input + 1000);                 //  вывод результата сложения переменной input  + 1000

// Console.Write("Введи первое число: "); //a
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введи второе число: "); //b
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber) // "=" - придание значения, "==" - проверка равно/неравно
// {
//     Console.WriteLine("Да, " + firstNumber + " является квадратом от числа " + secondNumber);
// }
// else // если число а не является квадратом от числа b
// {
//     Console.WriteLine("Нет, " + firstNumber + " НЕ является квадратом от числа " + secondNumber);
// }


//задание на работу с циклом
// Console.Write("Введи число N: ");
// int N = Convert.ToInt32(Console.ReadLine());            //задаем N
// int negativN = N * -1;                                  //задаем N отрицательное значение

// while (negativN <= N)
// {
//     Console.WriteLine(negativN + " ");
//     negativN++;                                         //negativN = negativN + 1   - инкремент; negativN-- = negativN -1  - декремент
// }


                                                //ДЗ Задача N1

// using System;

// public class Answer
// {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if (firstNumber > secondNumber)
//             Console.WriteLine("Первое число "+"`"+ firstNumber + "`"+" больше чем второе число"+  "`" + secondNumber + "`");
//         else
//             if (firstNumber < secondNumber)
//             Console.WriteLine("Первое число "+"`" + firstNumber + "`"+" меньше чем второе число "+"`" + secondNumber + "`");
//             else
//                 Console.WriteLine("Введенные числа равны "+ "`" +firstNumber+ "`");

//     }

//     // Не удаляйте и не меняйте метод Main!
//     static public void Main(string[] args)
//     {
//         int firstNumber,
//             secondNumber;

//         if (args.Length >= 2)
//         {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 9;
//             secondNumber = 9;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }


                                                    //ДЗ задача 2

// using System;

// public class Answer
// {
//     static int FindMax(int a, int b, int c)
//     {
//         // Введите свое решение ниже
//         if (a > b && a > c)
//         {
//           return(a);
//         }
//         else if (b > a && b > c) 
//         {
//            return(b);
//         }
//         else 
//         {
//             return(c);
//         }
//     }

//     // Не удаляйте и не меняйте метод Main!
//     static public void Main(string[] args)
//     {
//         int a,
//             b,
//             c;

//         if (args.Length >= 3)
//         {
//             a = int.Parse(args[0]);
//             b = int.Parse(args[1]);
//             c = int.Parse(args[2]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             a = 10;
//             b = 6;
//             c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }


                                                   //ДЗ задача 3

using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
if (number % 2 == 0)
{
Console.WriteLine("Число `"+number+"` чётное");
}
else
{
Console.WriteLine("Число `"+number+"` нечётное");
}
    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 10987;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}