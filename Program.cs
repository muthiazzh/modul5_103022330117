using System;

 public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T a,T b, T c)
    {
        dynamic m = a;
        dynamic n = b;
        dynamic p = c;
        dynamic max = m;
        if (n > max)
        {
            max = n;
            Console.WriteLine($"Nilai tertingg : {max}");
        } else if (p > n)
        {
            max = p;
            Console.WriteLine($"Nilai tertingg : {max}");
        } else
        {
            max = m;
            Console.WriteLine($"Nilai tertingg : {max}");
        }
    }
}

public class Program
{
     public static void Main(string[] args)
    {

        PemrosesData nilai = new PemrosesData();

        nilai.DapatkanNilaiTerbesar<int>(10,30,22);
    }
}