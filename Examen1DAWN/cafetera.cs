
using System;


//namespace EDexamenT6a8

class cafetera
{
    public cafetera(string m, string r, double agua, double totaldecapsulas)
    {
        this.m = m; //marca de la máquina cafetera
        this.r = r; //referencia del modelo
        this.totaldecapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
        this.agua = agua; //Cantidad de agua en el recipiente. 
        }





    public string m;
    public string r;
    public double agua;
    public double totaldecapsulas;


    public string consumoagua(double numerodecafe) //numero de cafés a hacer
    {
        double constante = 0.1;
        this.agua = this.agua - numerodecafe * constante; // Constante de consumo de agua 0.1l por cada unidad de café. 
        if (this.agua < 0.1)
        {   this.agua = 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else{ return "Quedan" + this.agua + " centilitros";}
    }

    public string consumocapsulas(double numerodecafe) //Hacer un café 
    {
        this.totaldecapsulas = this.totaldecapsulas - numerodecafe;
        if (this.totaldecapsulas < 0)
        {
            this.totaldecapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else {
            return "Quedan" + this.totaldecapsulas + "unidades";
        }
    }

    public double reponercapsulas(double cantidadcapsulas)
    {
        this.totaldecapsulas = this.totaldecapsulas + cantidadcapsulas;
        return this.totaldecapsulas;
    }
    public double llenardep(double litros)
    {
        this.agua = this.agua + litros;
        return this.agua;
    }


    public void verespecificacion(string r, string m)
    {
        this.m = m;
        this.r = r;
    }

}


class ejemplodemicafetera
{

    static void main()
    {


        cafetera mi_cafetera_ejemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(mi_cafetera_ejemplo.agua);
        Console.WriteLine(mi_cafetera_ejemplo.consumocapsulas(5));
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);
        Console.WriteLine(mi_cafetera_ejemplo.consumoagua(5));
        Console.WriteLine(mi_cafetera_ejemplo.agua);
        mi_cafetera_ejemplo.llenardep(0.5);
        Console.WriteLine(mi_cafetera_ejemplo.agua);
        mi_cafetera_ejemplo.reponercapsulas(3);
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);


    }

}