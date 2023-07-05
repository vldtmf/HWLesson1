//Составить программу, которая на вход принимает два числа
//а на выходе выдает какое число больше
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if(a > b){
    Console.WriteLine($"Больше число {a}");
}
else{
    Console.WriteLine($"Больше число {b}");
}