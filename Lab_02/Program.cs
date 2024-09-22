// Lab_02.cs
// <Возняк Едвард>
// Лабораторна робота № 2
// Лінійні програми
// Варіант 5
class Lab_2 
{
    static void Main(string[] args)
    {
        double alpha;
        double z1;
        double z2;

        Console.WriteLine("Enter alpha value in degrees: ");
        double alphaDegrees = double.Parse(Console.ReadLine());

        alpha = alphaDegrees * (Math.PI / 180.0); // converting from degrees to rad

        z1 = 1 - (1.0/4.0) * Math.Pow(Math.Sin(2 * alpha),2) + Math.Cos(2 * alpha);
        //z2 = Math.Pow(Math.Cos(alpha),2) + Math.Pow(Math.Cos(alpha),4);

        //bool resultsMatch = Math.Abs(z1 - z2) < 1e-8; // using 1e-8 for greater accuracy

        Console.WriteLine($"z1 = {z1:F8}");
        //Console.WriteLine($"z2 = {z2:F8}");
        //Console.WriteLine($"Match: {resultsMatch}"); // if there is match for 2 equations then true
    }
}
