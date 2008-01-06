using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long sum = 13;
            foreach (long entry in samples)
            {
                sum = ((sum - (sum & 255)) % 97) + entry;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepSize = 2820;
        public const string MaxCount = "fallback-edge";
        public const string LimitSize = "primary-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + entry) >= (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
