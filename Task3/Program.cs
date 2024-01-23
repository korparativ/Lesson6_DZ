// Задайте произвольную строку. Выясните, является ли она палиндромом.

void ProverkaPolin (string st1)
{
    bool pr = true;
    string st = st1.ToLower();

    for (int i=0; i<st.Length/2; i++)
    {
        if (st[i] != st[st.Length-1-i])
        pr = false;
    }
    if (pr == true)
    Console.WriteLine ($"{st1} - Полиндром");
    if (pr == false)
    Console.WriteLine ($"{st1} - Не полиндром");
}

string str = "Дед";

ProverkaPolin (str);