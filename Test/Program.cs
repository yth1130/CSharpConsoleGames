// int x;
// int y;
// int z;

// x = 10;
// y = 20;
// z = x + y;

// Console.WriteLine($"{x} + {y} = {z}");



int i = 10;
int j = 20;
// Console.WriteLine(Sum(i, j));
Console.WriteLine($"i:{i}, j:{j}");
Swap(i, j);
Console.WriteLine($"i:{i}, j:{j}");

int Sum(int a, int b)
{
    int result = a + b;
    return result;
}
void Swap(int a, int b)
{
    int temp = a;
    a = b;
    b = temp;
}



// string aaa = "aaa";
// string bbb = "bbb";

// Swap(aaa, bbb);

// Console.WriteLine(aaa);
// Console.WriteLine(bbb);

// void Swap(string a, string b)
// {
//     string temp = a;
//     a = b;
//     b = temp;
// }