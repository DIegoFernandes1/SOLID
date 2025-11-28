namespace SOLID._02_OCP.Good
{
    public enum EProductType
    {
        Electronic,
        Clothing,
        Fashion
    }

    //CLASSE PAI
    public abstract class Discount
    {
        public abstract double Calculate(double price);
    }

    //CLASSES FILHAS
    public class ElectronicDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * 0.1;
        }
    }

    public class ClothingDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * 0.2;
        }
    }

    public class FashionDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price * 0.3;
        }
    }
}
