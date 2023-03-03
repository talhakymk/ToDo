namespace ToDo;
using System;

class App{

    private Board board = new Board();

    public Board Board{ get { return board ;}}

public void Run(){
    int choice = -1;
    do{
        Menu.WriteMenu();
        choice = Menu.MakeChoice(6); // 5 adet seçeneğimiz olduğu için 6 sayısını yolladık
        if(choice == 5)
            return;
        ReflectionOfYourChoice(choice);
        
    }while(choice != 0);

}

public void ReflectionOfYourChoice(int choice){
    switch(choice){
        case 1:
            board.ListBoard();
            break;
        case 2:
            board.AddCardToBoard();
            break;
        case 3:
            board.RemoveFromBoard();
            break;
        case 4:
            board.Move();
            break;



    }
}



}
