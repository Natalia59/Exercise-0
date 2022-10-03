Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

int N = userNumber1;
int count = 1;

Console.Write(N + " -> ");

while (count <= N)
{
    if (count % 2 == 0) Console.WriteLine(count +", ");
    count++;
}
