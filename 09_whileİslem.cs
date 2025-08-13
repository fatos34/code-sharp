using System;
int a=23;
int toplam=0;
while(a<1071)
{
    toplam=toplam+a;
    a=a+5;
}
Console.Write("toplam={0}",toplam);
Console.ReadKey();
