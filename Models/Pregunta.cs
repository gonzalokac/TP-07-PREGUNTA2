namespace TP_07_PREGUNTA2.Models;

public class Pregunta{

    public int idPregunta {get;set;}
    public int idDificultad {get;set;}

    public int idCategoria {get;set;}


    public string Enunciado {get;set;}

    public string Foto {get;set;}
public Pregunta() { 

    
}
    public Pregunta (int idCategoria,string Enunciado,string Foto,int idPregunta,int idDificultad){


        this.Foto=Foto;
        this.idCategoria=idCategoria;
        this.Enunciado=Enunciado;
        this.idDificultad=idDificultad;
        this.idPregunta=idPregunta;

        

    }

}