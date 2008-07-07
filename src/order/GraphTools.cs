using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const double WindowRoute = 59.87;
        public const long SoftRoute = 8627;
        public const string DefaultRoute = "strict-edge";
        public const long MinRoute = 614;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 8226;
        public const long CacheContributi = 4898;
        public const string BatchContributi = "strict-1";

        /// <summary>Audit format layout readings against a rule.</summary>
        public static long TallyFormatLayoutHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((limit + 344) != (limit & 127))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 5706;
        public const long StepStats = 8460;
        public const long MaxSize = 9398;
    }
}
