
using System;


//namespace EDexamenT6a8
// reenombre el nombre de la clase ya que empezaba en minuscula y los metodos tambien//
class Cafetera
{
    //reenombro las varaiables, ya que el nombre que tenian nombres poco descritivos//
    //Encapsule los campos ya que desde fuera como estaban antes se podian acceder a variables que deberian de ser privadas, si niecesita saber lo que vale alguna variable 
    //tine que llamar al metodo ver especificacion que va a devolver un estring con toda la informacion de la cafetera//
    private string Marca;
    private string Referencia;
    ///<param  Referencia especifica el numero de referencia de una cafetera.</param>
    private  double CantidadAgua;
    private  double Totaldecapsulas;
    public Cafetera(string marca, string referencia, double cantidadagua, double totaldecapsulas)
    {
        //DESPUES//
        Marca = marca; //
        Referencia = referencia;
        CantidadAgua = cantidadagua;
        Totaldecapsulas = totaldecapsulas;
        //ANTES//
        /*
        m = m; //marca de la máquina cafetera
        this.r = r; //referencia del modelo
        this.totaldecapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
        this.agua = agua; //Cantidad de agua en el recipiente. 
        */
    }
    


   


    public string Consumoagua(double numerodecafe) //numero de cafés a hacer
    {
        double constante = 0.1;
        //repetia la variable cantidadAgua cuando no hacia falta, con un -= ya se puede evitar volver a nombrar la variable //
        CantidadAgua -= numerodecafe * constante; // Constante de consumo de agua 0.1l por cada unidad de café. 
        if (CantidadAgua < 0.1)
        {   CantidadAgua= 0;
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else{ return "Quedan" + CantidadAgua + " centilitros";}
    }

    public string Consumocapsulas(double numerodecafe) //Hacer un café 
    {
        //repetia la variable cantidadAgua cuando no hacia falta, con un -= ya se puede evitar volver a nombrar la variable//
        Totaldecapsulas -= numerodecafe;
        if (Totaldecapsulas < 0)
        {
            Totaldecapsulas = 0;
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else {
            return "Quedan" + Totaldecapsulas + "unidades";
        }
    }

    public double Reponercapsulas(double cantidadcapsulas)
    {
          //repetia la variable cantidadAgua cuando no hacia falta, con un += ya se puede evitar volver a nombrar la variable//
        Totaldecapsulas += cantidadcapsulas;
       /*return this.totaldecapsulas; *///ESTO NO HACE FALTA PORQUE YA ESTA MODIFICANDO LA VARIABLE EN SI NO HACE FALTA QUE LA DEVUELVA//
    }
    public double Llenardep(double litros)
    {
       CantidadAgua +=  litros;

       /* return this.agua; */ //ESTO NO HACE FALTA PORQUE YA ESTA MODIFICANDO LA VARIABLE EN SI NO HACE FALTA QUE LA DEVUELVA//
    }
    ///<summary>
    /// muestra las especificaciones del la cafetera 
    ///</summary>
    ///<remarks>Recuerde utilizar este metodo solo cuando necesites saber toda la informacion de la cafetra</remarks>
    ///<returns>Este metodo solo va a devolver un string con toda la informacion de la cafetera </returns>
   /* este metodo esta mal porque se supone que debe de devolver la informacion de la cafetera y no devuelve nada ni hace nada solo 
    * le reassigna un valo que ya tinene a dos variables.
    public void verespecificacion(string r, string m)
    {
        Marca = m;
        Referencia= r;
    }*/

    public string VerEspecificacion ()
    {
        return $"La marca de la cafetera es: {Marca}.  Su referencia es: {Referencia}. La cantidad de agua que tiene es: {CantidadAgua}. Tiene {Totaldecapsulas} capsulas";
    }
}


class ejemplodemicafetera
{

    static void main()
    {


        cafetera mi_cafetera_ejemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(mi_cafetera_ejemplo.CantidadAgua);
        Console.WriteLine(mi_cafetera_ejemplo.consumocapsulas(5));
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);
        Console.WriteLine(mi_cafetera_ejemplo.consumoagua(5));
        Console.WriteLine(mi_cafetera_ejemplo.CantidadAgua);
        mi_cafetera_ejemplo.llenardep(0.5);
        Console.WriteLine(mi_cafetera_ejemplo.CantidadAgua);
        mi_cafetera_ejemplo.reponercapsulas(3);
        Console.WriteLine(mi_cafetera_ejemplo.totaldecapsulas);


    }

}