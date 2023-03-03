namespace ToDo;
using System;

class Menu{

    static public void WriteMenu(){
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Taşımak");
        Console.WriteLine("(5) Çıkış");
    }

    public static int MakeChoice(int a){
        string? result = "";
        while(true){
            result = Console.ReadLine();
            if (result == null || result == ""){
                Console.WriteLine("Gecersiz giris");
                continue;
            }
            if(result.Length == 1 && result[0] - 48 > 0 && result[0] - 48 < a )
                return int.Parse(result);
             Console.WriteLine("Gecersiz giris");
        }
    }

    

    public static string IsNull(){
        string? result = "";
        while(true){
            result = Console.ReadLine();
            if (result == null || result == ""){
                Console.WriteLine("Gecersiz giris");
                continue;
            }
            else 
                return result;
    }
}

}