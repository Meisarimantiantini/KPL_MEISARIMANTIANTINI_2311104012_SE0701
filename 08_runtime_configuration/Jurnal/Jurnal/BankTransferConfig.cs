using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace jurnal
{
    public class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }

        private const string configFile = "bank_transfer_config.json";

        public BankTransferConfig()
        {
            if (File.Exists(configFile))
            {
                string jsonString = File.ReadAllText(configFile);
                BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
                this.lang = config.lang;
                this.transfer = config.transfer;
                this.methods = config.methods;
                this.confirmation = config.confirmation;
            }
            else
            {
                // nilai default
                lang = "en";
                transfer = new Transfer { threshold = 25000000, low_fee = 6500, high_fee = 15000 };
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
                confirmation = new Confirmation { en = "yes", id = "ya" };
                SaveConfig();
            }
        }

        public void SaveConfig()
        {
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configFile, jsonString);
        }
    }

    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
}
