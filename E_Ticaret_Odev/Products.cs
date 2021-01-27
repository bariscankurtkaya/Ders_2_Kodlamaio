//Barışcan KURTKAYA
//15.01.2020 C# 
//If you type wrong id and password then system will give you a trial account with 15000 money.

namespace E_Ticaret_Odev
{
    class Products //TR: Ürünülerin verisinin tutulduğu class. ENG: This class keeping products' datas.
    {
        public string Product_Type { get; set; } //TR: Ürünün tipini tutar. ENG: Keeps products type.
        public string Product_Name { get; set; } //TR:Ürünün ismini tutar. ENG: Keeps product name.
        public double Product_Prices { get; set; }  // TR:Ürünün fiyatını tutar. ENG: Keep product price.
        public int Product_Pieces { get; set; }  // TR:Üründen kaç adet olduğunu tutar. ENG: Keeps how many items are available.
    }
}
