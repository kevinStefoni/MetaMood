using System.Runtime.CompilerServices;

namespace MetaMood.Services
{
    public static class ClusterConvertor
    {

        public static string ToCluster(this int a)
        {
            return a switch
            {
                0 => "Happy",
                1 => "Sad",
                2 => "Ferocious",
                3 => "Upbeat Happy",
                4 => "Upbeat Sad",
                5 => "Relaxed",
                6 => "Anger",
                _ => "ERROR",
            };
        }

    }
}
