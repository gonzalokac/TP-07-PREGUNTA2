namespace TP_07_PREGUNTA2.Models;




public class Respuesta{

    public int idPregunta {get;set;}
    public int idRespuesta{get;set;}

    public int Opcion {get;set;}
    public bool Correcta {get;set;}

    public string Foto {get;set;}
    public string Contenido {get;set;}

    public Respuesta (int idRespuesta,int Opcion, string Contenido,string Foto,int idPregunta,bool Correcta){


        this.Foto=Foto;
        this.idRespuesta=idRespuesta;
        this.Contenido=Contenido;
        this.Correcta=Correcta;
        this.idPregunta=idPregunta;
        this.Opcion=Opcion;

        

    }

}