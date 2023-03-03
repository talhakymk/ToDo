namespace ToDo;
using System;

static class TeamMember{

   private static Dictionary<string,Int32> team = new Dictionary<string,int>{
    {"Talha" , 1},
    {"Zeynep", 2},
    {"Halil", 3},
    {"NassarElSonbati", 4}
   };

    public static Dictionary<string,Int32> Team { get { return team ;} }

}