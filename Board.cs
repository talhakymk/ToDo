namespace ToDo;
using System;

class Board{

    private List<Kart> todo = new List<Kart>();
    private List<Kart> inProgress = new List<Kart>();
    private List<Kart> done = new List<Kart>();

    public Board(){
        DefaultList def = new DefaultList();
        this.todo.AddRange(def.Defaultlist);
    }

    public void ListBoard(){
        Console.WriteLine("TODO Line");
        Console.WriteLine(" ************************");
        WriteList(todo);
        Console.WriteLine("In Progress Line");
        Console.WriteLine(" ************************");
        WriteList(inProgress);
        Console.WriteLine("DONE Line");
        Console.WriteLine(" ************************");
        WriteList(done);
        
    }

    public void WriteList(List<Kart> lisd){
        foreach (var item in lisd)
        {
            Console.WriteLine("Başlık      :" + item.Title );
            Console.WriteLine("İçerik      :" + item.Context);
            Console.WriteLine("Atanan Kişi :" + GetKeyByValue(item.Id));
            Console.WriteLine("Büyüklük    :" + item.Size);
            Console.WriteLine("-");
        }
    }

    public void AddCardToBoard(){
        int choice = 0;
        choice = ChoiceForColon();
        switch(choice){
            case 1: // TODO 
                AddToList(todo);
                break;
            case 2: // In Progress
                AddToList(inProgress);
                break;
            case 3: // DONE
                AddToList(done);
                break;
        }
    }

    public string GetKeyByValue(int value){
        foreach (var item in TeamMember.Team)
            if(item.Value == value)
                return item.Key; 
        return "null";

    }

    public void AddToList(List<Kart> lisd){
        string? Baslik = "";
        string? Icerik = "";
        Size boyut;
        int kisi;
        Console.Write("Başlık Giriniz                                  :");
        Baslik = Menu.IsNull();
        Console.Write("İçerik Giriniz                                  :");
        Icerik = Menu.IsNull();
        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        boyut = (Size)Menu.MakeChoice(6);
        Console.Write("Kişi Seçiniz                                    :");
        kisi = DoWeHaveThatPersonInOurTeam();
        Kart card = new Kart(Baslik , Icerik , kisi , boyut);
        lisd.Add(card);
    }

    public int DoWeHaveThatPersonInOurTeam(){
        int result;
        while(true){
            string? id = Menu.IsNull();
            if(int.TryParse(id , out result)){
                foreach (var item in TeamMember.Team)
                {
                    if(result == item.Value)
                        return result;   
                }
            }
            Console.WriteLine("Geçersiz giriş yaptın!");
        }
    }

    public void RemoveFromBoard(){
        int choice=0;
        Console.WriteLine("Silme işleminin yapılacağı kolonu seçmeniz gerekiyor");
        choice = ChoiceForColon();
        switch(choice){
            case 1: // TODO 
                RemoveFromList(todo);
                break;
            case 2: // In Progress
                RemoveFromList(inProgress);
                break;
            case 3: // DONE
                RemoveFromList(done);
                break;
        }
    }

        public void RemoveFromList(List<Kart> lisd ){
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            while(true){
                Console.Write(" Lütfen kart başlığını yazınız:");
                string? baslik = Menu.IsNull();
                foreach (var item in lisd)
                {
                    if(item.Title == baslik){
                        lisd.Remove(item);
                        Console.WriteLine("Başarıyla silindi");
                        return;
                    }     
                }
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choice = Menu.MakeChoice(3);
                if(choice == 1)
                    return;                  
            }   
        }

        public int ChoiceForColon(){
            int choice = -1;
                do{
                    choice = -1;
                    Console.WriteLine("Lütfen kolon seçiniz ?");
                    Console.WriteLine("1) ToDo");
                    Console.WriteLine("2) In Progress");
                    Console.WriteLine("3) DONE");
                    choice = Menu.MakeChoice(4);
                    
                }while(choice == -1);
                    return choice;
        }

        public void LastFunction(Kart item , int newColone){
            if(newColone == 1)
                todo.Add(item);
            else if(newColone == 2)
                inProgress.Add(item);
            else 
                done.Add(item);
            Console.WriteLine("Taşıma işlemi başarıyla tamamlandı");
        }

        public void MoveFromList(List<Kart> lisd){
            Console.WriteLine("Güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            while(true){
                Console.Write(" Lütfen kart başlığını yazınız:");
                string? baslik = Menu.IsNull();
                foreach (var item in lisd)
                {
                    if(item.Title == baslik){
                        Console.WriteLine("Hangi kolona taşınacağını seçiniz");
                        int newColone = ChoiceForColon();
                        lisd.Remove(item);
                        LastFunction(item , newColone);
                        return;
                    }     
                }
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choice = Menu.MakeChoice(3);
                if(choice == 1)
                    return;                  
            }   
        }

        public void Move(){
            int choice=0;
        Console.WriteLine("Güncelleme yapılacak kartın ilk kolonunu girmeniz gerekiyor");
        choice = ChoiceForColon();
        switch(choice){
            case 1: // TODO 
                MoveFromList(todo);
                break;
            case 2: // In Progress
                MoveFromList(inProgress);
                break;
            case 3: // DONE
                MoveFromList(done);
                break;
        }

            }

        
    }

    

