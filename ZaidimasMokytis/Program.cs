using ZaidimasMokytis;

//TeachingGame.MainMeniu();


var arrayInt = new int[] { 1, 2, 11, 3, 4 };
arrayInt = arrayInt.Add(5);
arrayInt = arrayInt.Add(6);
arrayInt = arrayInt.Add(7);
arrayInt = arrayInt.Add(8);
arrayInt = arrayInt.Add(9);
arrayInt = arrayInt.Add(10);
arrayInt = arrayInt.Remove(2);

for (int i = 0; i < arrayInt.Length; i++)
{
    Console.WriteLine($"index: {i}  value: {arrayInt[i]}");
}