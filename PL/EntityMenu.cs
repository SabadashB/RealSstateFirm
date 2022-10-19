using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class EntityMenu
    {
        public static void HelpMenu() => Console.WriteLine("In that program you can do such action as:\n" +
           "\t client - to add, remove or recive some information about clients;\n" +
           "\t estate - to add, change, remove or recive information about estate\n" +
           "\t end - to end work.");
        public static void ClientMenu() => Console.WriteLine("Client commands:\n" +
            "\taddclient - to add new client;\n" +
            "\tremoveclient - to remove any client;\n" +
            "\tshowallclients - to show all clients with main information about them;\n" +
            "\tsearchclient - to find train by its number\n\tend - to go to the other command group.\n Choose one of them");

        public static void ReservationMenu() => Console.WriteLine("Estate commands:\n" +
            "\taddestate - to add new client;\n" +
            "\tremoveestate - to remove any client;\n" +
            "\tshowallestetes - to show all clients with main information about them;\n" +
            "\tsearchestetes - to find train by its number\n\tend - to go to the other command group.\n Choose one of them" +
            "\tend - to go to the other command group.\n Choose one of them");
    }
}
