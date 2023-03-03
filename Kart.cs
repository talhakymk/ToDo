namespace ToDo;
using System;

enum Size {XS=1 , S , M , L , XL};
class Kart{

private string? title;

private string? context;

private int id;

private  Size size;

public Kart(){}
public Kart(string title , string context , int id , Size size){

    this.title = title;
    this.context = context;
    this.id = id;
    this.size = size;

}

public string? Title {
    get { return title ;}
    set { this.title = value ;}
}
public string? Context {
    get { return context ;}
    set { this.context = value ;}
}

public int Id {
    get { return id ;}
    set { this.id = value ;}
}

public Size Size{
    get{ return size ;}
    set{ this.size = value ;}
}


}