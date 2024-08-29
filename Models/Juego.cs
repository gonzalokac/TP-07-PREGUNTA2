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
  /*esto hay que hacer quedevuelva una pregunta*/
   return new Pregunta();
   
}
public  void ObtenerProximasRespuestas(int idPregunta){

}
 public bool VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        // Lógica para verificar si la respuesta es correcta
        // Este es un ejemplo simple; en una aplicación real, usarías una base de datos o alguna lógica más compleja
        // Supongamos que tenemos una estructura que guarda las respuestas correctas
        var respuestaCorrecta = ObtenerRespuestaCorrecta(idPregunta);
        return idRespuesta == respuestaCorrecta.Id;
    }

    // Este método obtiene la respuesta correcta para una pregunta dada
    public Respuesta ObtenerRespuestaCorrecta(int idPregunta)
    {
        // Lógica para obtener la respuesta correcta para la pregunta dada
        // Este es un ejemplo simple; en una aplicación real, esto probablemente se obtendría de una base de datos
        // Ejemplo estático de respuesta correcta
        return new Respuesta { Id = 2, Texto = "Respuesta Correcta" }; // Debes ajustar esto según tu implementación
    }
}


