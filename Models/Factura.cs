
namespace mvcajax.Models{

public class Factura {

    public int Numero {get; set;}

    public string Concepto {get;set;}

    public  double Importe {get;set;}

    public Factura (int Numero, string Concepto, double Importe)
    {
        this.Numero=Numero;
        this.Concepto=Concepto;
        this.Importe=Importe;

    }
  public Factura()
  {}

    public Factura(int Numero)
    {
        this.Numero=Numero;
    }
    // override object.Equals
    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        Factura otra= (Factura) obj;

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        if (otra.Numero==Numero)  {

            return true;
        } else { return false;}
        }





        
        // TODO: write your implementation of Equals() here
      
    
    
    // override object.GetHashCode
    public override int GetHashCode()

    {     return Numero.GetHashCode();
        
        // TODO: write your implementation of GetHashCode() here
       
    }

}
}


