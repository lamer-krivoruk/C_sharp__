int a = 5;
int b = 78;
int c = 3;
int d = 10;
int max = a;


if(max < b)
{
    max = b;
}
if(max < c)
{
    max = c;
}
if(max < d)
{
    max = d;
}
Console.Write("Самая тяжелая гиря весит ");
Console.WriteLine(max);