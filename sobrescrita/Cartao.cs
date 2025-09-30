public class Cartao
{
    public virtual void Debitar(decimal valor)
    {
        Console.WriteLine($"Débito de {valor:C} realizado no cartão.");
    }
}