
public class Juego{

 static string NombreUsuario {get;set;}

static int puntajeActual {get;set;}

static int cantidadPreguntasCorrectas {get;set;}

static List<Pregunta> preguntas {get;set;}

static List<Respuesta> respuestas {get;set;}

InicializarJuego(){
NombreUsuario.set("");
puntajeActual.set(0);
cantidadPreguntasCorrectas(0);


}
 static string ObtenerCategorias(string Lcategoria){
Lcategoria=LCategoria;
return Lcategoria;
} 
static string ObtenerDificultades(string Ldificultades){
Ldificultades=LDificultades;
return Ldificultades;

}

CargarPartida(string NombreUsuario, int dificultad, int categoria){


}

ObtenerProximaPregunta(){

}
ObtenerProximasRespuestas(int idPregunta){

}

VerificarRespuesta(int idPregunta, int idRespuesta){

return idPregunta;
}
}

