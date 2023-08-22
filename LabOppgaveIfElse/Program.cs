using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOppgaveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tema er if/else
            

            int alder = 18;
            if (alder > 17)
            {
                Console.WriteLine("Gammel nok til å kjøre bil");
            }
            else
            {
                Console.WriteLine("Gammel nok til å kjøre bil");
            }

            //dette betyr: Hvis alder er større enn 17, så skriv ut gammel nok
            //(else)hvis ikke, så skriv ikke gammel nok
            //en if er true eller false

            //Hvordan lese inn noe fra konsoll? eksempel under
            Console.WriteLine("Tast inn et tall");//Beskjed til bruker
            int tall = int.Parse(Console.ReadLine());//Her skjer den faktiske innlesningen. Variabelen tall får verdien av bruker.
            Console.WriteLine("Variabelen tall har nå verdien:" + tall);


            //oppgave 1
            //Sånn, da har vi nok av kodeeksempler til å lage noe selv. Oppgaven kommer under her. 
            //Lever koden på Teams. Lykke til.
            //De to første linjene er ferdige. Vi leser inn en temperatur.
            //Du skal lage en "if/else" som i eksempelet over.
            //Hvis temperatur er under null, skriv ut "minusgrader". Hvis ikke (else), skriv ut "varmegrader".
            //Hva skjer hvis det er 0 grader? Kan vi håndtere det?

            Console.WriteLine("Tast inn en temperatur, et heltall");
            int temperatur = int.Parse(Console.ReadLine());//leser inn temperatur


            //din if/else her

            //oppgave 2
            //Lik oppgaven over, men denne gangen skal du lage en metode, og kalle denne.
            //Så vi leser inn som over, kaller metoden, som har parameter/argument. Dette parameteret er temperaturen.
            //Metoden skal ikke returnere noe.
        }
    }
}
