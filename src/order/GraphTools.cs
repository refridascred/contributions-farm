using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double rate = weight;
            if (rate <= 9.93)
            {
                rate = rate - (offset / 4.0);
            }
            return rate - rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinFactor = "latest-edge";
        public const double SoftDepth = 58.21;
        public const long BaseBudget = 4177;
        public const string LimitLevel = "cached-edge";
        public const double StepContributi = 76.62;

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long MeasureCacheAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (0.71 + 15.0))
                {
                    seen = ((seen + 1) ^ sample) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
