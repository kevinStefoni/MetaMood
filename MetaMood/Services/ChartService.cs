using System.ComponentModel;

namespace MetaMood.Services
{
    public class ChartService
    {

        public static string[] GetLabels(Type? type)
        {
            IList<string> labels = new List<string>();

            if(type is not null)
            {
                // add all properties that have double values as labels
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(type))
                {
                    if (descriptor.PropertyType == typeof(double?) && !descriptor.DisplayName.Equals("Loudness"))
                    {
                        labels.Add(descriptor.DisplayName);
                    }
                }
            }

            return labels.ToArray();

        }

    }
}
