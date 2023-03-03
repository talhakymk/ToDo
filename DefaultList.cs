namespace ToDo;

 class DefaultList{
    private List<Kart> defaultlist = new List<Kart>();

    public DefaultList(){
        Kart kart1 = new Kart("talha" , "kaymak" , 3 , Size.XS);
        Kart kart2 = new Kart("ali" , "kaya" , 1 , Size.M);
        Kart kart3 = new Kart("taha" , "kaymaz" , 2 , Size.XL);
        defaultlist.Add(kart1);
        defaultlist.Add(kart2);
        defaultlist.Add(kart3);
       
    }

    public List<Kart> Defaultlist{ get {return defaultlist ;}}
}