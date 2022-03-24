using T1Library;

int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
string temp = "{";
char[] end = { ','};
for (int i = 0; i < mas.GetLength(0); i++)
{
    temp += "{";
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        temp += "{";
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            temp += mas[i, j, k];
            temp += ",";
        }
        temp = temp.TrimEnd(end);
        temp += "},";
    }
    temp = temp.TrimEnd(end);
    temp += "},";
}
temp = temp.TrimEnd(end);
temp += "}";
Console.WriteLine(temp);

MyStack arr = new MyStack();
arr.Push(1);
arr.Push(2);
arr.Push(3);
int a = arr.Pop();
Console.WriteLine();


