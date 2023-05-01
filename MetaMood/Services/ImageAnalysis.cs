using SixLabors.ImageSharp.Processing;
using System.Collections.Concurrent;
using Microsoft.Extensions.Caching.Memory;

namespace MetaMood.Services
{
    public class ImageAnalysis
    {

        public static async Task<Rgba32> GetDominantColorFromUrlAsync(string imageUrl)
        {

            // Download the image from the URL.
            using var httpClient = new HttpClient();
            using var response = await httpClient.GetAsync(imageUrl);
            using var stream = await response.Content.ReadAsStreamAsync();

            // Load the image using ImageSharp.
            using var image = Image.Load<Rgba32>(stream);

            // Analyze the image colors.
            var colorCount = new Dictionary<Rgba32, int>();

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    var pixelColor = image[x, y];

                    if (colorCount.TryGetValue(pixelColor, out var count))
                    {
                        colorCount[pixelColor] = count + 1;
                    }
                    else
                    {
                        colorCount[pixelColor] = 1;
                    }
                }
            }

            // Find the dominant color.
            var dominantColor = colorCount.Aggregate((maxItem, currentItem) => currentItem.Value > maxItem.Value ? currentItem : maxItem).Key;
            return dominantColor;
        }

        public static async Task<IDictionary<string, string>> AnalyzeImagesAsync(List<string> imageUrls)
        {
            var tasks = new List<Task<Rgba32>>();
            foreach (var imageUrl in imageUrls)
            {
                tasks.Add(GetDominantColorFromUrlAsync(imageUrl));
            }

            await Task.WhenAll(tasks);

            var dominantColors = new List<Rgba32>();

            foreach (var task in tasks)
            {
                dominantColors.Add(task.Result);
            }

            IDictionary<string, string> UrlAndColor = new Dictionary<string, string>();
            
            for(int i = 0; i < imageUrls.Count; i++)
            {
                UrlAndColor.Add(imageUrls[i], ToHex(dominantColors[i]));
            }

            return UrlAndColor;
        }

        public static string ToHex(Rgba32 color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        public static string GetInverse(string hexColor)
        {
            string hex = hexColor.Replace("#", "");

            int colorValue = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            int inverseColorValue = 0xFFFFFF - colorValue;

            return "#" + inverseColorValue.ToString("X6");
        }

    }
}


