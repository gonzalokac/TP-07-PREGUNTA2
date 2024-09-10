using  TP_07_PREGUNTA2.Models;

public class Juego{

 static string NombreUsuario {get;set;}

static int puntajeActual {get;set;}

static int cantidadPreguntasCorrectas {get;set;}

static List<Pregunta> preguntas {get;set;}

static List<Respuesta> respuestas {get;set;}

public void InicializarJuego(){
    NombreUsuario = "";
    puntajeActual= 0;
    cantidadPreguntasCorrectas=0;


}
static string ObtenerCategorias(string Lcategoria){
    Lcategoria=Lcategoria;
    return Lcategoria;
} 
static string ObtenerDificultades(string Ldificultades){
Ldificultades=Ldificultades;
return Ldificultades;

}

public static string CargarPartida(string NombreUsuario, int dificultad, int categoria){
return NombreUsuario;

}

public Pregunta ObtenerProximaPregunta(){
 
    Random random=new Random();
    int indice=random.Next(preguntas.Count);
    Pregunta preg=preguntas[indice];
   return preg;
   
}
public static Respuesta ObtenerProximasRespuestas(int idPregunta){
    
return new Respuesta();
}
 public static bool VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        int respuestaCorrecta = ObtenerRespuestaCorrecta(idPregunta);
         
        if(idRespuesta==respuestaCorrecta){
             puntajeActual+=1;
             cantidadPreguntasCorrectas+=1;
             preguntas.RemoveAt(idPregunta);
             return true;
        }else{
        return false;
        }
       
    }

    // Este método obtiene la respuesta correcta para una pregunta dada
    public static int ObtenerRespuestaCorrecta(int idPregunta)
    {
     respuestas=BD.ObtenerRespuestaXId(idPregunta);
    foreach(var r in respuestas){

        if(r.Correcta==true){
              return r.idRespuesta;
        }
    }
      return -1;

    }
}

