using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] canArray = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
        string[] chiArray = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        int canIndex = (year - 4) % 10;
        int chiIndex = (year - 4) % 12;

        if (canIndex < 0)
            canIndex += 10;
        if (chiIndex < 0)
            chiIndex += 12;

        string canYear = canArray[canIndex];
        string chiYear = chiArray[chiIndex];

        Console.WriteLine($"The lunar year corresponding to {year} is {canYear} {chiYear}");
    }
}
