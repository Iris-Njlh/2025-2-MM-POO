// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Olá, Michelly e Iris!");

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Cartao cartaoBase = new Cartao();
cartaoBase.Debitar(1234567891011);

Console.WriteLine("-- Cartao de Debito --");

Cartao CartaoDebito = new CartaoDebito();
CartaoDebito.Debitar(100);
