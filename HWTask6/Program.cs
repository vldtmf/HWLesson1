// На вход принимается число, в ответ является ли число чётным (да-нет)
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
double b = a / 2;
double c = b * 2;
if(c == a){
    Console.WriteLine("Введённое число чётное");
}
else{
    Console.WriteLine("Введённое число нечётное");
}

