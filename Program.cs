string [] ArrString = {"*", "One", "0", "Two", "three", "99", "nine", "ten","eleven"};
string []ansver = SortLengArr (ArrString);
Console.WriteLine(string.Join(" ", ArrString));
Console.WriteLine();
Console.WriteLine(string.Join(" ", ansver));
string [] SortLengArr(string[] arr)
{
    int index = 0;

    string[] StrArr = new string[arr.Length];
    for (int i = 0; i < ArrString.Length; i++)
    {

        int num = ArrString[i].Length;
        if (num <= 3)
        {
            StrArr[index] = arr[i];
            index++;
        }
    }
    return StrArr;
}