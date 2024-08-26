namespace TP_07_PREGUNTA2.Models;




public class Categoria{

public int idCategoria {get;set;}

public string Nombre {get;set;}

public string Foto {get;set;}

public Categoria (int idCategoria,string Nombre,string Foto){

    this.Foto=Foto;
    this.idCategoria=idCategoria;
    this.Nombre=Nombre;
    

}
public Categoria (){

}

}
