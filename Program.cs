// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Televisao tv = new Televisao(55f);

        tv.LigarTV();
        Console.WriteLine($"Canal atual: {tv.Canal}");
        tv.IrParaCanal(100);
        Console.WriteLine($"Canal atual: {tv.Canal}");
        tv.CanalAcima();
        Console.WriteLine($"Canal atual: {tv.Canal}");
        tv.CanalAbaixo();
        Console.WriteLine($"Canal atual: {tv.Canal}");
        tv.IrParaCanal(600); // canal inválido

        tv.DefinirVolume(50);
        Console.WriteLine($"Volume atual: {tv.ObterVolume()}");
        tv.AumentarVolume();
        Console.WriteLine($"Volume atual: {tv.ObterVolume()}");
        tv.AtivarMudo();
        Console.WriteLine($"Volume atual (mudo): {tv.ObterVolume()}");
        tv.DiminuirVolume();
        Console.WriteLine($"Volume atual: {tv.ObterVolume()}");

    }
}