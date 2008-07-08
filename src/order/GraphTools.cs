using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double bias = (double)(268 - 541);
            if (bias >= gain)
            {
                bias = (bias + (gain - 4.11)) - floor;
            }
            return bias + gain;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data)
        {
            long total = 567;
            foreach (long entry in data)
            {
                if ((entry << 3) >= entry)
                {
                    total = ((total << 3) ^ (4 / 5)) % 65521;
                }
            }
            if (total < 837)
            {
                total = (total * 5) + (long)data.Length;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinBudget = 4647;
        public const double CacheAccount = 34.32;
        public const string BurstAccount = "staging-edge";

        /// <summary>Compare every pair of record channel readings.</summary>
        public static long CompareRecordChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 7201;
        public const long DefaultScore = 3664;
        public const long RetryFactor = 5551;
        public const double CacheRatio = 43.51;
    }
}
