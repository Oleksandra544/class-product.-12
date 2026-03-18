using System;

// Абстрактний клас
abstract class Product
{
    protected string name;
    protected double price;
    protected int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    // Віртуальний метод
    public virtual void ShowInfo()
    {
        Console.WriteLine("Товар: " + name);
    }

    // Абстрактний метод
    public abstract double CalculateTotal();
}

// Клас-нащадок
class FoodProduct : Product
{
    public FoodProduct(string name, double price, int quantity)
        : base(name, price, quantity) { }

    // Перевизначення методу
    public override void ShowInfo()
    {
        Console.WriteLine("Харчовий товар: " + name);
        Console.WriteLine("Ціна: " + price);
        Console.WriteLine("Кількість: " + quantity);
    }

    public override double CalculateTotal()
    {
        return price * quantity;
    }
}

// Ще один клас-нащадок
class TechProduct : Product
{
    public TechProduct(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override void ShowInfo()
    {
        Console.WriteLine("Техніка: " + name);
        Console.WriteLine("Ціна: " + price);
        Console.WriteLine("Кількість: " + quantity);
    }

    public override double CalculateTotal()
    {
        return price * quantity;
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new FoodProduct("Хліб", 30, 5);
        Product product2 = new TechProduct("Ноутбук", 30000, 1);

        product1.ShowInfo();
        Console.WriteLine("Загальна вартість: " + product1.CalculateTotal());
        Console.WriteLine();

        product2.ShowInfo();
        Console.WriteLine("Загальна вартість: " + product2.CalculateTotal());
    }
}