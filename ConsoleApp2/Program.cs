//1.
String myName = "Prodromos";

Console.WriteLine("Hello my name is: " + myName);





//2.
Console.WriteLine("Give me one integer number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give me another one integer number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int add = firstNumber + secondNumber;
Console.WriteLine("The result of the addition is :" + add);

int divide = firstNumber / secondNumber;
Console.WriteLine("The result of divide is : " + divide);





//3.
int result1 = -1 + 5 * 6;
int result2 = 38 + 5 % 7;
int result3 = 14 + (-3 * 6 / 7);
//int result4 = 2 + 13 / 6 * 6 + Math.Sqrt(7);
int result5 = (6 ^ 4 + 5 ^ 7) / 9 % 4;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);
//Console.WriteLine(result4);
Console.WriteLine(result5);






//4.
Console.WriteLine("Age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Gender: ");
string gender = Console.ReadLine();

Console.WriteLine("You are " + gender + " and you look younger than " + age);







//5.

int seconds = 45678;
Console.WriteLine("The minutes are " + (seconds / 60) + "The hours are " + (seconds / 3600) );
Console.WriteLine("The days are " + (seconds / 86400) + "and the years are " + (seconds / 31556926));






//6.





//7.
Console.WriteLine("Celcius: ");
int celcius = Convert.ToInt32(Console.ReadLine());
int Kelvin = celcius + 273;
Console.WriteLine("Kelvin : " + Kelvin);
Console.WriteLine("Fahrenheit: " + celcius * 1.8 + 32);