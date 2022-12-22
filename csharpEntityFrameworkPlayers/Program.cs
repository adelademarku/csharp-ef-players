// See https://aka.ms/new-console-template for more information
using csharpEntityFrameworkPlayers;

Console.WriteLine("Hello, World!");

/*Milestone 1:
Nel program.cs svolgiamo le operazioni CRUD sull’entità Players, usando dei dati inseriti nel codice, senza chiederli all’utente:
1- creazione di un nuovo giocatore, secondo queste regole:
per il punteggio generiamo un numero decimale casuale da 1 a 10
per il numero di partite giocate e partite vinte un numero intero casuale da 1 a 100, 
stando attenti che il numero di partite vinte sia inferiore alle partite giocate.
2- visualizzazione del giocatore appena creato
3- modifica del nome e del cognome del giocatore
4- cancellazione del giocatore*/

using (Context db = new Context())
{

    int scores = new Random().Next(1, 10);
    int totMatches = new Random().Next(1, 100);
    int wonMatches = new Random().Next(1, totMatches);

    Player firstPlayer = new Player() { Name = "Simone", Surname = "Giannelli", Score = scores, NumberMatches = totMatches, NumberMatchesWon = wonMatches };

    firstPlayer.PrintPlayer();

    db.Add(firstPlayer);
    db.SaveChanges();
    Console.WriteLine("Player added in Database!");


    List<Player> players = db.Players
    .OrderBy(player => player.Name).ToList<Player>();

    firstPlayer.Name = "Yuri";
    firstPlayer.Surname = "Romanò";
    db.SaveChanges();

    firstPlayer.PrintPlayer();

    Console.WriteLine("Player name and surname modified  in Database!");

    db.Remove(firstPlayer);
    db.SaveChanges();

}