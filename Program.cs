/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int MethodC( int numbers)
{
    int a = 0;
    for(int i = 0;i < numbers;i++)
    {
    
    Console.WriteLine("Введите очередную цифру ");
    int number = Convert.ToInt32(Console.ReadLine());
    
      
       if(number  > 0) a = a + 1;
    }

    return a;
}
Console.Clear();
Console.Write("Введите сколько цифр будете вводить  ");
int numbers = Convert.ToInt32(Console.ReadLine());
if(numbers > 0)
{
 int result = MethodC(numbers);
 Console.WriteLine("Количество положительных чисел " + result);
} 
else
{
 Console.WriteLine("Введена некорректная информация");  
}
 
 /*Напишите программу, которая найдёт точку пересечения двух прямых,
  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.*/
  
  
  double CoordinateX(double b1,double k1,double b2,double k2)
 {
 double x = 0;
 
 x = (b2 - b1) / (k1 - k2);
 return x; 
 } 
  
 double CoordinateY(double b1,double k1,double x)
 { 
 double y = 0; 
  y = k1 * x + b1;

  return y;
 }

 Console.Write("Input a number b1: ");
 double b1 = Convert.ToDouble (Console.ReadLine());
 Console.Write("Input a number k1: ");
 double k1 = Convert.ToDouble (Console.ReadLine());
 Console.Write("Input a number b2: ");
 double b2 = Convert.ToDouble (Console.ReadLine());
 Console.Write("Input a number k2: ");
 double k2 = Convert.ToDouble (Console.ReadLine());
  
 if(k1 != k2) 
 {

   double X =  CoordinateX(b1,k1,b2,k2); 
   Console.WriteLine("Координат Х пересечения двух линий:" + X );
   double Y =  CoordinateY(b1,k1,X);
   Console.WriteLine("Координат У пересечения двух линий:" + Y );
 }
 else
 { 
    Console.WriteLine("Линии не пересекаютя");
 }