namespace Q_2
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _price;

        public Product()
        {
            this._productId = 0;
            this._productName = " ";
            this._price = 0.0;
        }

        public int ProductId
        {
            set { this._productId = value; }
            get { return _productId; }
        }


        public string ProductName
        {
            set { this._productName = value; }
            get { return _productName; }
        }

        public double Price
        {
            set { this._price = value; }
            get { return this._price; }
        }

        public Product(int _productId, string _productName, double _price)
        {
            this._productId = _productId;
            this._productName = _productName;
            this._price = _price;
        }

        public virtual void Display()
        {
            Console.WriteLine("***************** Product Info **********************");
            Console.WriteLine($"Product Id : {this._productId}");
            Console.WriteLine($"Product Name : {this._productName}");
            Console.WriteLine($"Price :{this._price} ");
        }
    }


}

