public class CartaoDebito
{
    public string Numero { get; set; }
    public string Bandeira { get; set; }

}


public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}