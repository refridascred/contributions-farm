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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell + hits) > hits) && !(((long)readings.Length >> 4) != (5 / 3)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
