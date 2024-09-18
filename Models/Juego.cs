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

public static bool CargarPartida(string NombreUsuario, int dificultad, int categoria){
preguntas=BD.ObtenerPreguntas( dificultad, categoria);
respuestas=BD.ObtenerRespuestas(preguntas);
if(preguntas!=null){
    return true;
} else{
    return false;
}
}
/* Para que necesito El nombre del usuario??*/

public static Pregunta ObtenerProximaPregunta(){
 
    Random random=new Random();
    int indice=random.Next(preguntas.Count);
    Pregunta preg=preguntas[indice];
    preguntas.RemoveAt(indice);
   return preg;
   
}
public static List<Respuesta> ObtenerProximasRespuestas(int idPregunta){
    List<Respuesta>LRespuestaPregunta=new List<Respuesta>();
    LRespuestaPregunta=BD.ObtenerRespuestaXId(idPregunta);
    return LRespuestaPregunta;
}
 public static bool VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        int respuestaCorrecta = ObtenerRespuestaCorrecta(idPregunta);
         
        if(idRespuesta==respuestaCorrecta){
             puntajeActual+=1;
             cantidadPreguntasCorrectas+=1;
             return true;
        }else{
        return false;
        }
       
    }

    // Este método obtiene la respuesta correcta para una pregunta dada
    public static int ObtenerRespuestaCorrecta(int idPregunta)
    {
         List<Respuesta>LRespuestaPregunta2=new List<Respuesta>();
        LRespuestaPregunta2=Juego.ObtenerProximasRespuestas(pregunta.idPregunta);
    foreach(var r in LRespuestaPregunta2){

        if(r.Correcta==1){
              return r.idRespuesta;
        }
    }
     
    }
}

