public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int Canal_MAX = 520;
    private const int Canal_MIN = 0;

    private int UltimoCanal = 0;
    private bool Mudo = false;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Volume = 10;
        Canal = 1;
        Estado = false;
    }
    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }



    public void LigarTV()
    {
        Estado = true;
        Canal = UltimoCanal;
        Console.WriteLine("tv ligada");
    }

    public void DesligarTV()
    {
        Estado = false;
        UltimoCanal = Canal;
        Console.WriteLine("tv deligada");
    }
    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume++;
        else
            Console.WriteLine("Volume já está no max.");
    }

   public void DiminuirVolume()
    {
        if (Volume > VOL_MIN)
    {
        Volume--;
        Mudo = false;
    }
        else
    {
        Console.WriteLine("Volume já está no mínimo.");
    }
    }
    public void AtivarMudo()
    {
        if (!Estado)
        {
            Console.WriteLine("TV desligada.");
            return;
        }

        Mudo = true;
        Console.WriteLine("TV em modo mudo.");
    }

    public int ObterVolume()
    {
        return Mudo ? 0 : Volume;
    }

    public void DefinirVolume(int valor)
    {
        if (!Estado)
        {
            Console.WriteLine("TV desligada.");
            return;
        }

        if (valor >= VOL_MIN && valor <= VOL_MAX)
        {
            Volume = valor;
            Mudo = false;
        }
        else
        {
            Console.WriteLine($"Volume inválido: {valor}. Deve estar entre {VOL_MIN} e {VOL_MAX}.");
        }
    }

    public void CanalAcima()
    {
        if (!Estado)
        {
            Console.WriteLine("TV desligada.");
            return;
        }

        if (Canal < Canal_MAX)
        {
            Canal++;
        }
        else
        {
            Console.WriteLine("Último canal alcançado.");
        }
    }

    public void CanalAbaixo()
    {
        if (!Estado)
        {
            Console.WriteLine("TV desligada.");
            return;
        }

        if (Canal > Canal_MIN)
        {
            Canal--;
        }
        else
        {
            Console.WriteLine("Já está no menor canal.");
        }
    }

    public void IrParaCanal(int numero)
    {
        if (!Estado)
        {
            Console.WriteLine("TV desligada.");
            return;
        }

        if (numero >= Canal_MIN && numero <= Canal_MAX)
        {
            Canal = numero;
        }
        else
        {
            Console.WriteLine($"Canal inválido: {numero}. Deve estar entre {Canal_MIN} e {Canal_MAX}.");
        }
    }
}