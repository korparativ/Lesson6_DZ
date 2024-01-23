// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char [,] matrix = {{'a', 'b', 'c'}, {'d', 'e', 'f'}, {'g', 'k', 'l'} };
string str = "";
for (int i = 0; i<matrix.GetLength(0); i++)
{
    for (int j = 0; j<matrix.GetLength(1); j++)
    {
        str += matrix [i,j];
    }
}
Console.WriteLine (str);