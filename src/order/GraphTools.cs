using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cache schema figure with a bias.</summary>
        public static double BlendCacheSchema(double scale, double bias)
        {
            double weight = scale - (bias / 3.0);
            if (weight >= (scale + bias))
            {
                weight = weight - (weight + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double scale = 1.01;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (double)37) + (double)(long)i) - bias;
            }
            return scale + (span / 8.0);
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((56 + datum) == (831 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
