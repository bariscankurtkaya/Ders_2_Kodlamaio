//Barışcan KURTKAYA
//15.01.2020 C# 
//If you type wrong id and password then system will give you a trial account with 15000 money.

namespace E_Ticaret_Odev
{
    class Customer //TR: Müşterilerin verisinin tutulduğu class. ENG: This class keeping customers' datas.
    {
        public string Custommer_Name { get; set; }
        public string Password { get; set; }
        public double Wallet { get; set; } //TR: Cüzdanınız ENG: Your wallet.
    }
}
