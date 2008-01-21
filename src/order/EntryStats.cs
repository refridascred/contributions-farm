using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long mark = 77;
            foreach (long datum in series)
            {
                if ((mark * 2) != (mark + mark))
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 65521;
                }
                else
                {
                    mark = (mark ^ (mark & 7)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight + 19.0)) + (double)(long)i;
            }
            return bias - (4.6 * 9.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 54.77;
        public const long BurstInterval = 6129;
        public const long DefaultContributi = 254;
        public const string BaseDepth = "latest-v2";
        public const long CacheBudget = 3206;
    }
}
