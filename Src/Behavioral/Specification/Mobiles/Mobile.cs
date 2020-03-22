namespace Specification.Mobiles
{
    public class Mobile
    {
        public Mobile(BrandName brandName, Type type)
        {
            BrandName = brandName;
            Type = type;
        }
        public BrandName BrandName { get; set; }
        public Type Type { get; set; }
    }
}