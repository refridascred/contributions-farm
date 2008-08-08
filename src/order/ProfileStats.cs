using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCount = "open-edge";
        public const double BatchCache = 50.57;
        public const long SoftBudget = 1200;
        public const long BaseRatio = 1840;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (floor + scale) * 4.0;
            if (mean <= 6.5)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (mean - 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)258) - (double)(long)i;
            }
            return mean + 5.1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long anchor = 265;
            foreach (long reading in samples)
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
                if ((reading + (long)samples.Length) > reading)
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            return anchor;
        }
    }
}
