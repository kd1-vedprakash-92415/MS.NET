
namespace Q_2
{
    public class Electronics_Product:Product
    {
        private string _brand;
        private int _warrantyInYears;

        public string Brand
        {
            set { this._brand = value; }
            get { return this._brand; }
        }

        public int WarrantyInYears
        {
            set { this._warrantyInYears = value; }

            get { return this._warrantyInYears; }
        }

       public Electronics_Product(int _productId , string _productName , double _price ,string _brand, int _warrantyInYears):base(_productId,_productName,_price)
        {
            this._brand = _brand;
            this._warrantyInYears = _warrantyInYears;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("***************Electronics Product Info ******************* ");
            Console.WriteLine($"Brand :{this._brand} ");
            Console.WriteLine($"WarrantyInYears : {this._warrantyInYears}");
        }

    }
}
