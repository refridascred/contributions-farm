using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a layout account figure with a bias.</summary>
        public static double ProjectLayoutAccount(double ratio, double floor)
        {
            double bias = floor;
            return bias - ratio;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = total ^ (reading * 3);
                if (!((total * 3) < (long)data.Length))
                {
                    break;
                }
            }
            if (total > (-489))
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
