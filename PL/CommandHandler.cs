using BL;
using System;

namespace PL
{
    public class CommandHandler
    {
        public void CommandHandle()
        {
            EntityMenu.HelpMenu();
            bool stop = false;
            while (!stop)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "client":
                        EntityMenu.ClientMenu();
                        string data = Console.ReadLine();
                        switch (data)
                        {
                            case "addclient":
                                bool isSuccess = false;
                                while (!isSuccess)
                                {
                                    try
                                    {
                                        InputLogic.InputClient();
                                        isSuccess = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                                Console.WriteLine("Client was added!");
                                break;
                            case "showallclients":
                                string clients = null;
                                isSuccess = false;
                                while (!isSuccess)
                                {
                                    try
                                    {
                                        clients = PrintService.StringObjects(InputLogic.FileClientPath).ToString();
                                        isSuccess = true;
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                                }
                                Console.WriteLine(clients);
                                break;
                            case "remove":
                                string pasportData = null;
                                isSuccess = false;
                                while (!isSuccess)
                                {
                                    try
                                    {
                                        pasportData = InputLogic.InputForClient("pasportData");
                                        isSuccess = true;
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                                }
                                try { RemoveProvider.RemoveClient(InputLogic.FileClientPath, pasportData); }
                                catch (Exception ex) { Console.WriteLine(ex.Message); }
                                break;
                        }
                        break;
                    case "end":
                        stop = true;
                        Console.WriteLine("Tap any key on the keyboard, to stop program.");
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }
            }
        }
    }
}
