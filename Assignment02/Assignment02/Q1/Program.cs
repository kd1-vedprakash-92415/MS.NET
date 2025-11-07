namespace Q1
{
    struct Student
    {
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        public Student()
        {
            this._name = "Ved";
            this._gender = true;
            this._age = 22;
            this._std = 16;
            this._div = 'A';
            this._marks = 100;
        }
        public Student(string name, bool gender, int age, int std, char div, double marks) 
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._std = std;
            this._div = div;
            this._marks = marks;
        }

        public string Name
        {
            set { this._name = value; }
            get { return _name; }            
        }
        
        public bool Gender
        {
            set { this._gender = value; }
            get { return _gender; }            
        }
        public int Age
        {
            set { this._age = value; }
            get { return _age; }
        }
        public int Std
        {
            set { this._std = value; }
            get { return _std; }
        }
        public char Div
        {
            set { this._div = value; }
            get { return _div; }
        }
        public double Marks
        {
            set { this._marks = value; }
            get { return _marks; }
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name : ");
            this._name = Console.ReadLine();
            Console.WriteLine("Enter Geneder (for male : M, for female : F): ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            if (ch == 'm') this._gender = true;
            else this._gender = false;
            //this._gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Age ");
            this._age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Standard ");
            this._std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENtr DIvision : ");
            this._div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter The Marks");
            this._marks = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name : {this._name}");
            if (this._gender)
            {
                Console.WriteLine("Gender : Male");
            }
            else
            {
                Console.WriteLine("Gender : Female");
            }
                //Console.WriteLine($"Gender : {this._gender}");
            Console.WriteLine($"Age : {this._age}");
            Console.WriteLine($"Std : {this._std}");
            Console.WriteLine($"DIvision : {this._div}");
            Console.WriteLine($"Marks : {this._marks}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.AcceptDetails();
            s1.PrintDetails();
        }
    }
}
