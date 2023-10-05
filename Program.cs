Console.Write("Введите размер массива: "); // пользователь вводит кол-во элементов массива
int length = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[length];

for (int i = 0; i < arr.Length; i++) // заполнение массива элементами
{
  Console.Write("Введите элемент массива: ");
  arr[i] = Console.ReadLine();
}
Console.WriteLine(String.Join(",", arr));


string[] resultArray = new string[arr.Length];
int realSize = 0;
foreach (var value in arr)
{
  if (value.Length <= 3) // проверка элементов по количеству символов
  {
    resultArray[realSize] = value;
    Console.Write(resultArray[realSize] + " ");
    realSize++;
  }
}
