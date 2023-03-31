using System.ComponentModel;

namespace MetaMood.Services
{
    public class ChartService
    {

        /// <summary>
        /// This function uses reflection to get all of the properties of the given type that should make it into the bar chart.
        /// </summary>
        /// <param name="type">The type of the model whose data will be graphed</param>
        /// <returns>An array of strings containing the labels for the X-axis of the graph</returns>
        public static string[] GetLabels(Type? type)
        {
            IList<string> labels = new List<string>();

            if(type is not null)
            {
                // add all properties that have double values as labels
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(type))
                {
                    if (descriptor.PropertyType == typeof(double?) && !descriptor.DisplayName.Equals("Loudness") && !descriptor.DisplayName.Equals("Tempo"))
                    {
                        labels.Add(descriptor.DisplayName);
                    }
                }
            }

            return labels.ToArray();

        }
    }
}
