
// *** ЗАДАЧА *** Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно три символа.

void ShowArray(string[] arrayString)
{
    Console.Write("[");
    bool once = false;
    for (int i = 0; i < arrayString.Length; i++)
        if (arrayString[i].Length <= 3)
        {
            if(i == 0 || ! once) 
            {
                Console.Write(arrayString[i]);
            } else 
            {
                Console.Write(", " + arrayString[i]);
            }
            once = true;
        }
    Console.Write("]");
}

Console.WriteLine("Введите значения разделяя запятой : ");
string text = Console.ReadLine();

string[] arrayString = text.Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
Console.Write("Ваш массив : [");
for (int i = 0; i < arrayString.Length; i++)
{
    if(i == arrayString.Length-1)
            {
               Console.Write(arrayString[i]); 
            }
            else Console.Write(arrayString[i]+", "); 
}
Console.Write("]");

Console.WriteLine();

Console.Write("Ваш масив со значениями меньше 3х семволов: ");
ShowArray(arrayString);
