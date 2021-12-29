using System.Collections.Generic;
namespace mvcajax.Models {

    public class PersonaRepositorio{

        public List<Persona> BuscarTodas() {
            Persona p1 =new Persona("pedro", "lopez");
            Persona p2 =new Persona("pablo", "gomez");
            Persona p3 =new Persona("maria", "diaz");

            List<Persona> lista=new List<Persona>();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            return lista;
        }
    }
}