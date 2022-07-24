
namespace ConsoleApp1.Models
{
    public class Transaction 
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; private set; }
        public DateOnly SellDate {  get; private set; }
        Random randNum = new Random();

        public Transaction( Vehicle vehicle, DateOnly date) 
        {
            Vehicle = vehicle;
            Id = randNum.Next();
            SellDate = date;  
        }
    }
}
