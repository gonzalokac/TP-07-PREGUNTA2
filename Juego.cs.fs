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
   return new Pregunta();
   
}
public  void ObtenerProximasRespuestas(int idPregunta){
    
return new Respuesta();
}
 public bool VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        var respuestaCorrecta = ObtenerRespuestaCorrecta(idPregunta);
        if(idRespuesta=respuestaCorrecta){
             puntajeActual+=1;
             cantidadPreguntasCorrectas+=1;
             LPreguntas.RemoveAt(idPregunta-1)
             return True
        }else{
        return False
        }
       
    }

    // Este método obtiene la respuesta correcta para una pregunta dada
    public Respuesta ObtenerRespuestaCorrecta(int idPregunta)
    {
     new Respuesta R=ObtenerRespuestas(idPregunta)
        return R;

    }
}

