using  TP_07_PREGUNTA2.Models;

public static class Juego{

 static string NombreUsuario {get;set;}

public static int puntajeActual {get;set;}

public static int cantidadPreguntasCorrectas {get;set;}

public static List<Pregunta> preguntas {get;set;}

static List<Respuesta> respuestas {get;set;}

public static int cantPreguntas {get;set;}

public static void InicializarJuego(){
    NombreUsuario = "";
    puntajeActual = 0;
    cantidadPreguntasCorrectas = 0;
}

public static bool CargarPartida(string NombreUsuario, int dificultad, int categoria){
    preguntas=BD.ObtenerPreguntas( dificultad, categoria);
    respuestas=BD.ObtenerRespuestas(preguntas);
    cantPreguntas=preguntas.Count();
    return preguntas != null;
}

/* Para que necesito El nombre del usuario??*/

public static Pregunta? ObtenerProximaPregunta(){
    if(preguntas.Count == 0) return null;
    Pregunta preg = preguntas[new Random().Next(0, preguntas.Count)];
    preguntas.Remove(preg);
    return preg;
}

 public static bool VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        Respuesta? respuestaCorrecta = ObtenerRespuestaCorrecta(idPregunta);
         
        if(idRespuesta==respuestaCorrecta.idRespuesta){
             puntajeActual+=1;
             cantidadPreguntasCorrectas+=1;
             return true;
        }else{
            return false;
        }
       
    }

    // Este método obtiene la respuesta correcta para una pregunta dada
   public static Respuesta? ObtenerRespuestaCorrecta(int idPregunta)
    {
        List<Respuesta> LRespuestaPregunta2 = BD.ObtenerRespuestaXId(idPregunta);

        foreach (Respuesta r in LRespuestaPregunta2)
        {
            if (r.Correcta)
            {
                return r;
            }
        }
        
        // Si no se encuentra una respuesta correcta, devolver null después del bucle.
        return null;
    }

}

