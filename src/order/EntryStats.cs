using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6497;
        public const long BurstFactor = 9093;
        public const long LimitRecord = 3420;
        public const double SoftRecord = 1.04;
        public const long RetrySize = 2865;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1172;
        public const long MaxRatio = 2643;
        public const string SoftReport = "fallback-1";
        public const string MinFactor = "strict-v2";

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long ClassifyRecordFilter(long seed, long bound)
        {
            if (2 < (seed % 64))
            {
                return 2;
            }
            else
            {
                if ((bound <= (196 >> 3)) && (bound <= (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (7 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
