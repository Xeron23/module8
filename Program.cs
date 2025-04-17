using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        config.read();
        config.ubahBahasa(config.lang, config);
        if (config.lang == "en")
        {
            Console.WriteLine("Current Language: English");
            Console.WriteLine("Transfer: ");
            int uang = int.Parse(Console.ReadLine());
            int totalBiaya;
            if(uang < config.transfer.threshold)
            {
                totalBiaya = uang+ config.transfer.low_fee;
                Console.WriteLine("Low fee: " + config.transfer.low_fee);
            }
            else
            {
                totalBiaya = uang + config.transfer.high_fee;
                Console.WriteLine("High fee: " + config.transfer.high_fee);
            }
            Console.WriteLine("Total amount= " + totalBiaya);
            Console.WriteLine("Select transfer method:");
            for (int i = 0; i < config.methods.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + config.methods[i]);
            }
            Console.WriteLine("Please type "+config.confirmation.en+ "to confirm the transaction");
            String conf = Console.ReadLine();
            if (conf == config.confirmation.en)
            {
                Console.WriteLine("transfer is complete");
            }else
            {
                Console.WriteLine("transfer is cancelled");
            }

        }
        else
        {
            Console.WriteLine("Current Language: Indonesian");
            Console.WriteLine("Transfer: ");
            int uang = int.Parse(Console.ReadLine());
            int totalBiaya;
            if (uang < config.transfer.threshold)
            {
                totalBiaya = uang + config.transfer.low_fee;
                Console.WriteLine("Low fee: " + config.transfer.low_fee);
            }
            else
            {
                totalBiaya = uang + config.transfer.high_fee;
                Console.WriteLine("High fee: " + config.transfer.high_fee);
            }
            Console.WriteLine("Total amount= " + totalBiaya);
            Console.WriteLine("Pilih metode transfer");
            for (int i = 0; i < config.methods.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + config.methods[i]);
            }
            Console.WriteLine("Ketik " + config.confirmation.en + " untuk mengonfirmasi transaksi");
            String conf = Console.ReadLine();
            if (conf == config.confirmation.en)
            {
                Console.WriteLine(" Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine(" Transfer dibatalkan");
            }
        }
    }
}