#region p1
//using System;

//class Car
//{
//    public int Id { get; set; }
//    public string Brand { get; set; }
//    public double Price { get; set; }

//    // 1. Default constructor
//    public Car()
//    {
//        Id = 0;
//        Brand = "Unknown";
//        Price = 0;
//    }

//    // 2. Constructor with one parameter (Id)
//    public Car(int id)
//    {
//        Id = id;
//        Brand = "Unknown";
//        Price = 0;
//    }

//    // 3. Constructor with two parameters (Id, Brand)
//    public Car(int id, string brand)
//    {
//        Id = id;
//        Brand = brand;
//        Price = 0;
//    }

//    // 4. Constructor with all three parameters
//    public Car(int id, string brand, double price)
//    {
//        Id = id;
//        Brand = brand;
//        Price = price;
//    }

//    // Override ToString() for easy display
//    public override string ToString()
//    {
//        return $"Car -> Id: {Id}, Brand: {Brand}, Price: {Price}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Using different constructors
//        Car car1 = new Car();                       // Default
//        Car car2 = new Car(101);                    // Id only
//        Car car3 = new Car(102, "Toyota");          // Id and Brand
//        Car car4 = new Car(103, "BMW", 50000);      // All parameters

//        // Print cars
//        Console.WriteLine(car1);
//        Console.WriteLine(car2);
//        Console.WriteLine(car3);
//        Console.WriteLine(car4);
//    }
//}

#endregion
#region p2
//using System;

//class Calculator
//{
//    // 1. Add two integers
//    public int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    // 2. Add three integers
//    public int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    // 3. Add two doubles
//    public double Sum(double a, double b)
//    {
//        return a + b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calc = new Calculator();

//        // Test each overload
//        Console.WriteLine("Sum of 2 integers (5 + 10): " + calc.Sum(5, 10));
//        Console.WriteLine("Sum of 3 integers (1 + 2 + 3): " + calc.Sum(1, 2, 3));
//        Console.WriteLine("Sum of 2 doubles (2.5 + 3.7): " + calc.Sum(2.5, 3.7));
//    }
//}

#endregion
#region p3
//using System;

//// Base class
//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    // Constructor to initialize X and Y
//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//        Console.WriteLine($"Parent constructor called: X={X}, Y={Y}");
//    }
//}

//// Derived class
//class Child : Parent
//{
//    public int Z { get; set; }

//    // Constructor chaining to base class
//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//        Console.WriteLine($"Child constructor called: Z={Z}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create an instance of Child
//        Child childObj = new Child(5, 10, 15);
//        Console.WriteLine($"Child values: X={childObj.X}, Y={childObj.Y}, Z={childObj.Z}");
//    }
//}

#endregion
#region p4
//using System;

//// Base class
//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    // Method to calculate product
//    public virtual int Product()
//    {
//        return X * Y;
//    }
//}

//// Derived class
//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    // 1. Using 'new' keyword
//    public new int Product()
//    {
//        return X * Y * Z;
//    }

//    // 2. Using 'override' keyword
//    // Uncomment this and comment the 'new' method to see override behavior
//    /*
//    public override int Product()
//    {
//        return X * Y * Z;
//    }
//    */
//}

//class Program
//{
//    static void Main()
//    {
//        Parent p = new Parent(2, 3);
//        Child c = new Child(2, 3, 4);

//        Console.WriteLine("Parent Product: " + p.Product());

//        // Using child instance directly
//        Console.WriteLine("Child Product (accessing via Child): " + c.Product());

//        // Using child instance as Parent reference
//        Parent pc = c;
//        Console.WriteLine("Child Product (accessing via Parent reference): " + pc.Product());
//    }
//}

#endregion
#region p5
//using System;

//// Base class
//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    // Override ToString()
//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//// Derived class
//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    // Override ToString()
//    public override string ToString()
//    {
//        return $"({X}, {Y}, {Z})";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Parent p = new Parent(2, 3);
//        Child c = new Child(2, 3, 4);

//        // Direct instances
//        Console.WriteLine("Parent instance: " + p);
//        Console.WriteLine("Child instance: " + c);

//        // Polymorphism: Parent reference pointing to Child object
//        Parent poly = c;
//        Console.WriteLine("Polymorphic reference: " + poly);
//    }
//}

#endregion
#region p6
//using System;

//// Define the interface
//interface IShape
//{
//    double Area { get; }   // get-only property
//    void Draw();           // method to draw the shape
//}

//// Implement the interface in Rectangle class
//class Rectangle : IShape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    // Constructor
//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    // Implement Area property
//    public double Area
//    {
//        get { return Width * Height; }
//    }

//    // Implement Draw method
//    public void Draw()
//    {
//        Console.WriteLine($"Drawing a rectangle of width {Width} and height {Height}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create a rectangle
//        IShape rect = new Rectangle(5, 3);

//        // Call Draw method
//        rect.Draw();

//        // Print area
//        Console.WriteLine("Area: " + rect.Area);
//    }
//}

#endregion
#region p7
//using System;

//// Interface with default method
//interface IShape
//{
//    double Area { get; }   // get-only property
//    void Draw();           // abstract method

//    // Default implementation
//    void PrintDetails()
//    {
//        Console.WriteLine("This is a shape with area: " + Area);
//    }
//}

//// Class implementing the interface
//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    // Implement Area property
//    public double Area
//    {
//        get { return Math.PI * Radius * Radius; }
//    }

//    // Implement Draw method
//    public void Draw()
//    {
//        Console.WriteLine($"Drawing a circle with radius {Radius}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IShape circle = new Circle(3);

//        // Call Draw method
//        circle.Draw();

//        // Call default PrintDetails method from interface
//        circle.PrintDetails();
//    }
//}

#endregion
#region p8
//using System;

//// Define the interface
//interface IMovable
//{
//    void Move();   // abstract method
//}

//// Class implementing the interface
//class Car : IMovable
//{
//    public string Brand { get; set; }

//    public Car(string brand)
//    {
//        Brand = brand;
//    }

//    // Implement Move method
//    public void Move()
//    {
//        Console.WriteLine($"{Brand} car is moving forward!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create a Car object
//        Car myCar = new Car("Toyota");

//        // Use an interface reference
//        IMovable movableCar = myCar;

//        // Call Move via interface
//        movableCar.Move();
//    }
//}

#endregion
#region p9
//using System;

//// First interface
//interface IReadable
//{
//    void Read();
//}

//// Second interface
//interface IWritable
//{
//    void Write();
//}

//// Class implementing both interfaces
//class File : IReadable, IWritable
//{
//    public string FileName { get; set; }

//    public File(string fileName)
//    {
//        FileName = fileName;
//    }

//    // Implement Read method
//    public void Read()
//    {
//        Console.WriteLine($"Reading data from {FileName}");
//    }

//    // Implement Write method
//    public void Write()
//    {
//        Console.WriteLine($"Writing data to {FileName}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create a File object
//        File myFile = new File("data.txt");

//        // Use the methods
//        myFile.Read();
//        myFile.Write();

//        // Using interface references
//        IReadable readableFile = myFile;
//        IWritable writableFile = myFile;

//        readableFile.Read();
//        writableFile.Write();
//    }
//}

#endregion
#region p10
//using System;

//// Base class
//abstract class Shape
//{
//    // Virtual method with default implementation
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing Shape");
//    }

//    // Abstract method: must be implemented by derived classes
//    public abstract double CalculateArea();
//}

//// Derived class
//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    // Override Draw method
//    public override void Draw()
//    {
//        Console.WriteLine($"Drawing Rectangle of width {Width} and height {Height}");
//    }

//    // Implement abstract CalculateArea method
//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create a Rectangle object
//        Rectangle rect = new Rectangle(5, 3);

//        // Call Draw and CalculateArea
//        rect.Draw();
//        Console.WriteLine("Area of Rectangle: " + rect.CalculateArea());
//    }
//}

#endregion
