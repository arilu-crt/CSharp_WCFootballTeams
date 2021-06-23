namespace football_teams_csharp.Model{

public class Argentina : Team{
    public string Name{get; set;}
    public Argentina(string country, int NumberOfWC, bool IsInEurope){
 Nickname = "La Albiceleste";
    Country = "Argentina";
    NumberOfWC= 2;
    IsInEurope = false;

   /*  CcurrentPlayers.Add(new  Player() {PlayerName="Messi"});
    CcurrentPlayers.Add(new  Player() {PlayerName="Aguero"});
    CcurrentPlayers.Add(new  Player() {PlayerName="DiMaria"});
    CcurrentPlayers.Add(new  Player() {PlayerName="Dybala"});
    CcurrentPlayers.Add(new  Player() {PlayerName="Otamendi"});
    CcurrentPlayers.Add(new  Player() {PlayerName="Rodriguez"});
    CcurrentPlayers.Add(new  Player() {PlayerName="Montiel"});

    IcconicPlayers.Add(new  Player() {PlayerName="Maradona"});
    IcconicPlayers.Add(new  Player() {PlayerName="Messi"});
    IcconicPlayers.Add(new  Player() {PlayerName="Pochettino"});
    IcconicPlayers.Add(new  Player() {PlayerName="Mascherano"});
    IcconicPlayers.Add(new  Player() {PlayerName="Batistuta"}); */
    }
   
    /* CurrentPlayers={"Messi", "Aguero", "DiMaria", "Dybala", "Otamendi", "Rodriguez", "Montiel"};

    IconicPlayers={"Maradona", "Messi", "Pochettino", "Mascherano", "Batistuta"};  */

}
}

