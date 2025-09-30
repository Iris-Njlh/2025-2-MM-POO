public class CartaoDebito : Cartao
{
    public override void Debitar(decimal valor)
    {
        Console.WriteLine($"Compra {valor:C} realizado no cartão de débito.");
    }
}