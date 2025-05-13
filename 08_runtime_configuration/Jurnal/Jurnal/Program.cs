using System;

namespace jurnal
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig config = new BankTransferConfig();

            // input jumlah uang
            if (config.lang == "en")
                Console.WriteLine("Please insert the amount of money to transfer:");
            else
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");

            int amount = int.Parse(Console.ReadLine());

            // menentukan biaya transfer
            int fee = (amount <= config.transfer.threshold) ? config.transfer.low_fee : config.transfer.high_fee;
            int total = amount + fee;

            // output biaya transfer
            if (config.lang == "en")
            {
                Console.WriteLine($"Transfer fee = {fee}");
                Console.WriteLine($"Total amount = {total}");
            }
            else
            {
                Console.WriteLine($"Biaya transfer = {fee}");
                Console.WriteLine($"Total biaya = {total}");
            }

            // memilih metode transfer
            if (config.lang == "en")
                Console.WriteLine("Select transfer method:");
            else
                Console.WriteLine("Pilih metode transfer:");

            for (int i = 0; i < config.methods.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {config.methods[i]}");
            }

            int metode = int.Parse(Console.ReadLine());

            // konfirmasi transfer
            if (config.lang == "en")
                Console.WriteLine($"Please type \"{config.confirmation.en}\" to confirm the transaction:");
            else
                Console.WriteLine($"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:");

            string confirmationInput = Console.ReadLine();

            bool isConfirmed = (config.lang == "en" && confirmationInput == config.confirmation.en) ||
                               (config.lang == "id" && confirmationInput == config.confirmation.id);

            if (isConfirmed)
            {
                if (config.lang == "en")
                    Console.WriteLine("The transfer is completed");
                else
                    Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                if (config.lang == "en")
                    Console.WriteLine("Transfer is cancelled");
                else
                    Console.WriteLine("Transfer dibatalkan");
            }
        }
    }
}
