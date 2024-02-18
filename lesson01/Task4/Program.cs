int a = 20;
int b = 7;
int c = 9;
int d = 4;
int e = 10;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine(max);