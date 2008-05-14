using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count + 12))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
