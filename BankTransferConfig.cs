using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
class BankTransferConfig
{
    public String lang { get; set; }
    public transfer transfer { get; set; }
    public String[] methods { get; set; }
    public confirmation confirmation { get; set; }

    public void read()
    {
        String filepath = "bank_transfer_config.json";
        String configJsonData = File.ReadAllText(filepath);     
        BankTransferConfig data = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
        this.lang = data.lang;
        this.transfer = data.transfer;
        this.methods = data.methods;
        this.confirmation = data.confirmation;

    }

    public void ubahBahasa(String leng, BankTransferConfig data)
    {
        String filepath = "bank_transfer_config.json";
        if (lang == "en")
        {
            data.lang = "id";
        }
        else
        {
            data.lang = "en";
        }
        data.lang = lang;
        String json = JsonSerializer.Serialize(data);
        
        
        File.WriteAllText(filepath, json);
    }
}

class transfer
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }
}

class confirmation
{
    public String en { get; set; }
    public String id { get; set; }
}