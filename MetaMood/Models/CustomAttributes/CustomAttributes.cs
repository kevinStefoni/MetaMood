namespace MetaMood.Models.CustomAttributes
{
    public class CustomAttributes
    {
        [AttributeUsage(AttributeTargets.Property)]
        public class Searchable : Attribute
        {

        }

        [AttributeUsage(AttributeTargets.Property)]
        public class Cluster : Attribute
        {

        }
    }

}
