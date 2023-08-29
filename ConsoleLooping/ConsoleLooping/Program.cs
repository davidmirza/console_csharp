
static void sisi(int jumlah, Boolean kanan, string parameter)
{
    string bd = "";
    Console.WriteLine((kanan) ? "Rata Kanan" : "Rata Kiri");
    for (int y = 0; y < jumlah; y++)
    {
        bd += parameter;
        string sp = "";
        if (kanan)
        {

            for (int d = 0; d < jumlah - y; d++)
            {
                sp += " ";
            }
        }
        string rs = sp + bd;
        Console.WriteLine(rs);
    }
    Console.WriteLine("\n");
}
static void piramid(int jumlah, string parameter)
{
    string bd = "";
    Console.WriteLine("piramid");
    int ln = parameter.Count();
    int pjln = (ln > 1) ? ln - (ln - 1) : 1;
    int val = 6;
    int backward = (ln > 3) ? jumlah + (val + (4 * (ln - 3))) : (ln == 1 ? jumlah - 2 : ln == 2 ? jumlah + 2 : jumlah + 6);
    for (int x = 0; x < jumlah; x++)
    {
        string spc = "";
        bd += parameter;

        if (x >= 1)
        {
            for (int d = 0; d < pjln; d++)
            {
                bd += parameter;
            }
        }
        for (int d = backward; d >= 0; d--)
        {
            spc += " ";
        }
        backward -= ln;
        string result = spc + bd;
        Console.WriteLine(result);
    }
}

sisi(5, true, "*");
sisi(5, false, "+");
piramid(5, "*");