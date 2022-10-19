using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.BLLExeptions;

namespace PL
{
    public class InputLogic
    {
        //file paths for reservations and trains
        public static readonly string FileClientPath = @"D:\Лаба\Clients.bin";
        public static readonly string FileEsatePath = @"D:\Лаба\Clients.bin";

        //methods to set date and time


        //methods to insert train value
        public static void InputClient()
        {
            bool isSuccess = false;
            string name = null, sername = null, phone = null, pasportData = null, bankNumber = null;
            while (!isSuccess)
            {
                try
                {
                    name = InputForClient("name");
                    sername = InputForClient("sername");
                    phone = InputForClient("phone");
                    pasportData = InputForClient("pasportData");
                    bankNumber = InputForClient("bankNumber");
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            EntityService.AddClient(FileClientPath, name, sername, phone, pasportData, bankNumber);
        }
        public static string InputForClient(string line)
        {
            string pattern, data;
            if (line == "name")
            {
                pattern = "[A-Z]{1}[a-z]";
                Console.WriteLine("Enter Client name(Example: John):");
                data = Console.ReadLine();
                if (!VerifyInputService.IsInputCorrect(data, pattern))
                    throw new NotPassedValueException();
                return data;
            }
            else if (line == "sername")
            {
                pattern = "[A-Z]{1}[a-z]";
                Console.WriteLine("Enter Client serame(Example: Johnson):");
                data = Console.ReadLine();
                if (!VerifyInputService.IsInputCorrect(data, pattern))
                    throw new NotPassedValueException();
                return data;
            }
            else if (line == "phone")
            {
                pattern = "^[+]{1}[0-9]{10}$";
                Console.WriteLine("Enter Client phone(Example: +3805023345):");
                data = Console.ReadLine();
                if (!VerifyInputService.IsInputCorrect(data, pattern))
                    throw new NotPassedValueException();
                return data;
            }
            else if (line == "pasportData")
            {
                pattern = "^[A-D]{1}[0-9]{10}$";
                Console.WriteLine("Enter Client pasportData(Example: A3805023345):");
                data = Console.ReadLine();
                if (!VerifyInputService.IsInputCorrect(data, pattern))
                    throw new NotPassedValueException();
                return data;
            }
            else if (line == "bankNumber")
            {
                pattern = "^[0-9]{8}$";
                Console.WriteLine("Enter Client Name(Example: 35023345):");
                data = Console.ReadLine();
                if (!VerifyInputService.IsInputCorrect(data, pattern))
                    throw new NotPassedValueException();
                return data;
            }
            else throw new NotPassedValueException();
        }
    }
}
