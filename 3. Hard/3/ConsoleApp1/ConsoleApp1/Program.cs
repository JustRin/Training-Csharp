using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Check products = new Check();
            products.setName("Cookies");
            products.setPrice(10);
            products.setWeight(0.2);

            products.setSum(21);

            products.printProductInfo();
            products.printBuyInfo();
        }
    }

    public class Products
    {
        public int sum;
        public double sum_price, sum_weight;
        public string name;
        public double price;
        public double weight;

        public void setName(string name_product)
        {
            name = name_product;
        }
        public string getName()
        {
            return name;
        }
        public void setPrice(double pr)
        {
            price = (pr >= 0 ? pr : 0);
        }
        public double getPrice()
        {
            return price;
        }
        public void setWeight(double wgh)
        {
            weight = wgh;
        }
        public double getWeight()
        {
            return weight;
        }
    }

    public class Buy : Products
    {
        public Buy()
        {
            sum = 0;
            sum_price = 0.0;
            sum_weight = 0.0;

        }

        public void setSum(int value)
        {
            sum = (value >= 0 ? value : 0);
            sum_price = sum * getPrice();
            sum_weight = sum * getWeight();
        }
        public int getSum()
        {
            return sum;
        }
        public double getSumPrice()
        {
            return sum_price;
        }
        public double getSumWeight()
        {
            return sum_weight;
        }
    }
    public class Check : Buy
    {
        public void printProductInfo()
        {
            Console.WriteLine("Товар: " + getName());
            Console.WriteLine("Цена: " + getPrice() + "$");
            Console.WriteLine("Вес: " + getWeight() + "кг.");
        }
        public void printBuyInfo()
        {
            Console.WriteLine("Товара куплено: " + getSum() + "шт.");
            Console.WriteLine("На сумму: " + getSumPrice() + "$");
            Console.WriteLine("Общий вес: " + getSumWeight() + "кг.");
        }
    }
}
