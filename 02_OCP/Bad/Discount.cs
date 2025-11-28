namespace SOLID._02_OCP.Bad
{
    public enum EProductType
    {
        Electronic,
        Clothing,
        Fashion
    }

    public class Discount
    {
        public double Calculate(EProductType productType, double price)
        {
            switch (productType)
            {
                case EProductType.Electronic:
                    return price * 0.9; // 10% discount
                case EProductType.Clothing:
                    return price * 0.8; // 20% discount
                case EProductType.Fashion:
                    return price * 0.85; // 15% discount
                default:
                    return price;
            }
        }
    }
}
