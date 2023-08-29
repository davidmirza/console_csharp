
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
static void piramid(int jumlah, string parameter, Boolean Diamond)
{
    string bd = "";
    int ln = parameter.Count();
    int pjln = (ln > 1) ? ln - (ln - 1) : 1;
    int val = 6;
    int backward = (ln > 3) ? jumlah + (val + (4 * (ln - 3))) : (ln == 1 ? jumlah - 2 : ln == 2 ? jumlah + 2 : jumlah + 6);
    string result = "";
    //Console.WriteLine(pjln);
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
        result = spc + bd;
       
        Console.WriteLine(result);
    }
    if (Diamond)
    {
       // Console.WriteLine("\n d " + backward);
        string bl = "";
        int rm = result.Length;
        for(int z = 0; z < rm ; z++)
        {
            bl += parameter;
        }
        int prm = 0;
        string spc2 = "";
        for (int x = jumlah-1 ; x>= 0; x--)
        {
            string results = bl.Substring(0, rm);
            
            if (x != jumlah - 1) {
                spc2 += " ";
                Console.WriteLine(spc2+results);
            }
            rm -= 2;
            prm++;
        }
    }
}
//static void diamond(int jumlah, string parameter)
//{
//    piramid(jumlah, parameter);
//}
sisi(5, true, "*");
sisi(5, false, "+");
piramid(5, "b*r",false);
piramid(5, "x",true);