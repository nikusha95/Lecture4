// See https://aka.ms/new-console-template for more information

//1 2 3 4 ...100000

int[] arr; //double string, byte, sbyte ...
arr = new int[10];
//0 1 2 3 4 5 6 7 8 9 --- index
//0 0 0 0 0 0 0 0 0 0 --- values
arr[1] = 12;
// Error: arr[10] = 7
//0 12 0 0 0 0 0 0 0 0 --- values


int[] arr1 = new int[10];

int[] arr2 = { 1, 2, 3, 10 };

Console.WriteLine(arr2[3]);
Console.WriteLine(arr2.Length);

//int x = 10;

string s = "some string";

Console.WriteLine(s[0]);
Console.WriteLine(s.Length);

//som
string s1 = s.Substring(0, 3);
string s2 = s.Remove(1, 3); //

Console.WriteLine(s);
Console.WriteLine(s2);
Console.WriteLine(s1);
//
char[] cArr = s.ToCharArray(); // ['s','o','m'....]


char c = s[0];
//

bool isUpper = char.IsUpper(c);
bool isLower = char.IsLower(c);

if (isUpper)
{
    Console.WriteLine($"Is upper {c}");
}
else
{
    Console.WriteLine($"Is lower {c}");
    char upper = char.ToUpper(c);

    Console.WriteLine(upper);
}
//
// Console.WriteLine(s[1]);
//Console.WriteLine(s.Length); //writes string length

string input = Console.ReadLine();
if (input != null)
{
    bool containsS = input.Contains('s'); //check if string contains s symbol
    string[] arrStr = input.Split(' ');
    int length = arrStr.Length;
    int index = 0;

    while (length != 0)
    {
        Console.WriteLine(arrStr[index]);
        index++;
        length--;
        //do something
    }
}

int iterator = 10;
//
// while (iterator != 0)
// {
//     Console.WriteLine(iterator);
//     iterator--;
// }

do
{
    Console.WriteLine(iterator);
    iterator--;
} while (iterator != 0);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"hello from for cycle {i}");
}

int j = 0;
while (j < 10)
{
    Console.WriteLine($"Hello from while {j}");
    j++;
}

//for exercise 11 
// int x = 123;
//
// Console.WriteLine(x%10);