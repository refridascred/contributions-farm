using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)(9 + 55);
            if (bias > bias)
            {
                bias = ((bias + (6.91 / 2.0)) - weight) + offset;
            }
            return bias - 0.1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftBudget = 919;
        public const long SoftRatio = 3219;
        public const long LimitSpan = 196;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long bound)
        {
            long mark = 13;
            foreach (long reading in levels)
            {
                if (950 > mark)
                {
                    mark = ((mark * 5) + 697) ^ reading;
                }
            }
            if (mark > 696)
            {
                mark = ((mark << 3) ^ (bound ^ 62)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinScore = 7414;
        public const long RetryEntry = 9408;
        public const string SoftEntry = "local-v2";
        public const string SoftWidth = "stable-v2";
        public const double BatchEntry = 4.03;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
