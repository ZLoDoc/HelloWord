Console.Clear();
int n = 5;
int x = 0;
int y = 1;
int nums = 1;
//int[,] snail;
for (; x <= n-1; x++)
{

    Console.SetCursorPosition(x, y);
    Console.WriteLine(nums);
    nums = nums + 1;
}
//Console.WriteLine(x);
for (; y <= n - 1; y++)
{

    Console.SetCursorPosition(x, y);
    Console.WriteLine(nums);
    nums = nums + 1;
}