namespace mvcajax.Models

{
    public class Cliente
    {

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Cliente( string Dni, string Nombre, string Apellidos){

            this.Dni = Dni;
            this.Nombre = Nombre;
            this.Apellidos= Apellidos;
        }


        public Cliente()
        {}
    }

}



       