using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "latest-1";
        public const string CacheOrder = "local-1";
        public const long SoftOrder = 2094;
        public const long StepLevel = 2208;
        public const long LimitScore = 7005;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinScore = "fallback-1";
        public const long WindowFormat = 7640;
        public const long MaxCount = 633;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + ((long)i + 976)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (tally % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 1.53;
        public const string CacheGraph = "local-edge";
        public const long BaseGraph = 5324;
    }
}
