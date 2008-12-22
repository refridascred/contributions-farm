using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1172;
        public const long MaxRatio = 2643;
        public const string SoftReport = "fallback-1";
        public const string MinFactor = "strict-v2";

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long limit)
        {
            long sum = 732;
            foreach (long reading in samples)
            {
                if ((limit > reading) && ((reading >> 1) < limit))
                {
                    sum = (sum * 3) + (549 ^ reading);
                }
            }
            return sum;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double gain = (double)(241 % 5);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
