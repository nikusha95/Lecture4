// See https://aka.ms/new-console-template for more information


//1 2 3 4 ...100000

using System.Threading.Channels;

// int[] arr; //double string, byte, sbyte ...
// arr = new int[10];
// //0 1 2 3 4 5 6 7 8 9
// arr[1] = 12;
//
// int[] arr1 = new int[10];
//
// int[] arr2 = { 1, 2, 3, 10 };
//
// Console.WriteLine(arr2.Length);

//int x = 10;

// string s = "some string";
//
// char[] cArr = s.ToCharArray();
//
// char c = s[0];
//
// bool isUpper = Char.IsUpper(c);
// bool isLower = Char.IsLower(c);
// if (isUpper)
// {
//     Console.WriteLine($"Is upper {c}");
// }
// else
// {
//     Console.WriteLine($"Is lower {c}");
//     char upper = Char.ToUpper(c);
//
//     Console.WriteLine(upper);
// }
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
        Console.WriteLine("Hello");
        length--;
        //do something
    }
}

int iterator = 10;

// while (iterator != 0)
// {
//     Console.WriteLine(iterator);
//     iterator--;
// }
//
// do
// {
//     Console.WriteLine(iterator);
//     iterator--;
// } while (iterator != 0);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("hello from for cycle");
}

int j = 0;
while (j != 10)
{
    Console.WriteLine("Hello from while");
    j++;
}

//for exercise 11 
// int x = 123;
//
// Console.WriteLine(x%10);