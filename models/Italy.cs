namespace football_teams_csharp.Model{
public class Italy:Team{
     public string Name{get; set;}
    public Italy(string country, int NumberOfWC, bool IsInEurope){
 Nickname = "Gli Azzurri";
    Country = "Italy";
    NumberOfWC= 4;
    IsInEurope = true;

   /*  CurrentPlayers={"Locatelli", "Kean", "Palmieri", "Barella", "Belotti", "Chiellini", "Immobile"};

    IconicPlayers="{Ronaldo", "Ronaldinho", "Rivaldo", "Pele", "Zico"}; */
    }
   
    

}
}

