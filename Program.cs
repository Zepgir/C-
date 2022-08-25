//Первая задача
Console.WriteLine("Первая задача");

int a =5;
 int b = 7;
    if (a > b)
         Console.WriteLine($"max = {a}  min = {b}");
               
    else 
         Console.WriteLine($"max = {b}  min = {a}");
              
              



//Вторая задача
Console.WriteLine("Вторая задача");

int n1 = 2;
int n2 = 3;
int n3 = 7;
var max = n1;
    if (n2 > max) max = n2;
    if (n3 > max) max = n3;
 Console.WriteLine($"max: {max}");



//Третья задача
Console.WriteLine("Третья задача");

int n = 4 ;
 if (n % 2 == 0) Console.WriteLine("Четное");
 else Console.WriteLine("Нечетное");


//Четвертая задача
Console.WriteLine("Четвертая задача");

int N = 5;
int count = 1;
while( count < N) {
    if (count % 2 == 0)
    Console.WriteLine(count);
    count = count + 1;
}