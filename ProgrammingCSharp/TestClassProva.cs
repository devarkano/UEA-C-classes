
abstract class Trem
{
    public string modelo { get; set; }
    public abstract void acelerar();
    public abstract void Desacelerar();

}
abstract class Veículo
{
    public string modelo { get; set; }
    public abstract void acelerar();
    public abstract void Desacelerar();
}


class trem : Veículo
{

    public override void Desacelerar()
    {
        Console.WriteLine("Carro Desacelerando . . .");

    }
    public override void acelerar()
    {
        Console.WriteLine("Carro Acelerando. . .");

    }

}

class carro : Veículo
{

    public override void Desacelerar()
    {
        Console.WriteLine("Carro Desacelerando . . .");

    }
    public override void acelerar()
    {
        Console.WriteLine("Carro Acelerando. . .");

    }

}

class Avião : Veículo
{


    public override void Desacelerar()
    {
        Console.WriteLine("Avião Desacelerando . . .");
    }
    public override void acelerar()
    {
        Console.WriteLine("Avião acelerando . . .");
    }

}

class program
{
    static void main()
    {
        Veículo meucarro = new carro();
        meucarro.modelo = "fusca";
        meucarro.acelerar();
        meucarro.Desacelerar();

        Veículo meuAvião = new Avião();
        meuAvião.modelo = "Boing 747";
        meuAvião.acelerar();
        meuAvião.Desacelerar();

        Veículo trem = new trem();
        trem.modelo = "Trem de Hoghwarts";
        trem.acelerar();
        trem.Desacelerar();

    }

}