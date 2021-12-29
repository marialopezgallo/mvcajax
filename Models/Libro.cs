namespace mvcajax.Models
{

    public class Libro
    {


        public int Numero {get; set;}
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public Libro(int Numero, string Titulo, string Autor)
        {
            this.Numero=Numero;
            this.Titulo = Titulo;
            this.Autor = Autor;

        }
        public Libro()
        { }
        // override object.Equals
        public override bool Equals(object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            Libro otra= (Libro) obj;

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        if (otra.Numero==Numero)  {

            return true;
        } else { return false;}
        

            
            
            // TODO: write your implementation of Equals() here
           
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            
            return Numero.GetHashCode();
        }
    }

}
