Console.WriteLine("Please, enter 3 int numbers");
int n1=int.Parse(Console.ReadLine());
int n2=int.Parse(Console.ReadLine());
int n3= int.Parse(Console.ReadLine());

int max=n1, mid=n2;

if (mid > max)
{
    max = n2;
    mid = n1;
}

if (n3 > mid)
{
    if (n3 > max)
    {
        mid = max;
        max = n3;
    }
    else { // n3 < max =>
        mid = n3;
    }
}
else { //n3<mid
    ///לא צריך לעשות כלום
    /// אפשר למחוק את הבלוק else

}

Console.WriteLine("The big number is: " + max);
Console.WriteLine("The medium number is: " +mid);


