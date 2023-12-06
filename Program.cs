using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap so tien ban muon doi");
        int usd = Convert.ToInt32(Console.ReadLine());
        int vnd = usd * 32000;
        Console.WriteLine("vay tien VN la : "+vnd);
}
}