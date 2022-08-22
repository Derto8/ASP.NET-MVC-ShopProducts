
namespace MagazineShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Balance { get; set; }
        public double Spend { get; set; }

        //public User(string name, string adress, int balance, int spend)
        //{
        //    Name = name;
        //    Adress = adress;
        //    Balance = balance;
        //    Spend = spend;
        //}

        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spend += price;
        }
    }
}
