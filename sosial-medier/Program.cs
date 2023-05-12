//Oppgave - Social Media

//Lag applikasjon FriendFace. Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm. Her trenger en bruker en profilside med diverse info om seg (ta gjerne inspirasjon fra andre sosiale medier),

//Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.

//Når programmet starter opp skal du lage en hovedbruker som er “innlogget”. Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.

//Lag et kommandbasert meny i konsollen der du kan:

//Legge til forskjellige brukere som venn (på den som er innlogget)
//Fjerne brukere som venn
//Printe ut en liste av alle man har lagt til som venn
//Velge en av vennene og printe ut profilinformasjonen deres.

// See https://aka.ms/new-console-template for more information
using sosial_medier;
var MainUser = new Person("Terje", 25, "single");
var socialMediaAccounts = new List<Person>();
int chosenIndex;
initializeAccounts();
Console.WriteLine($"Welcome to FriendFace,{MainUser}, choose what you want to do:");
Console.WriteLine("1.add a friend");
Console.WriteLine("2.remove a friend");
Console.WriteLine("3. see your friends");
Console.WriteLine("4.look up a firends profile");
var answer= int.Parse(Console.ReadLine());
runShit();
void runShit()
{
    if (answer==1)
    {
        Console.WriteLine("choose a friend to add:");
        printFriends();
        chooseFreind();
        MainUser.addFriend(socialMediaAccounts[chosenIndex]);


    } else if (answer==2)
    {
        
    } else if (answer==3)
    {
        
    }else if (answer==4)
    {
        
    }
    else
    {

    }
}

void initializeAccounts()
{
    socialMediaAccounts.Add(new Person("Kåre", 25, "singel"));
    socialMediaAccounts.Add(new Person("Iman", 25, "singel"));
    socialMediaAccounts.Add(new Person("Eivind", 25, "singel"));
    socialMediaAccounts.Add(new Person("Marie", 25, "singel"));

}
void printFriends()
{
    for(var i = 0; i < socialMediaAccounts.Count; i++)
    {
        Console.WriteLine(socialMediaAccounts[i].Name + i);
    }

}
int chooseFreind()
{
   
    chosenIndex  = int.Parse(Console.ReadLine());
    return chosenIndex;

}