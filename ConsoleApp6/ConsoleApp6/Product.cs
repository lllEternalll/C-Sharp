using System.Xml.Linq;

namespace ConsoleApp6
{
    public class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;

        public Product(string name, decimal price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    throw new ArgumentException("Name Error. null or empty");
                }
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price < 0)
                {
                    throw new ArgumentException("Price Error. price < 0");
                }
                _price = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
        }
        public decimal TotalValue => _price * _quantity;


        public void Restock(int amount)
        {
            if (amount > 0)
            {
                _quantity += amount;
            }
            else
            {
                Console.WriteLine("Restock Error. amount <= 0");
            }
        }

        public void Sell(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Sell Error. amount <= 0");
            }
            if (amount <= _quantity)
            {
                _quantity -= amount;
            }
            else
            {
                Console.WriteLine("Sell Error. amount > quantity");
            }
        }

        public string GetInfo()
        {
            return $"Товар: {_name}, Ціна: {_price}, Кількість: {_quantity}, Загальна вартість: {TotalValue}";
        }
    }

}