using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 4.24;
        public const long BatchLayout = 2811;
        public const long MaxFactor = 998;
        public const double LimitLayout = 61.0;

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepFactor = 28.61;
        public const long BatchDepth = 6691;
        public const double CacheRatio = 90.41;
        public const long LimitNotes = 7696;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = (mark - origin) + 75;
                if ((matches - (long)i) <= matches)
                {
                    mark = (mark + (origin - mark)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 103;
        public const long MaxScore = 1477;
        public const long SoftCount = 2674;
        public const long WindowBudget = 1602;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
