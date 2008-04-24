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

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long limit)
        {
            long span = seed - limit;
            if ((seed <= (limit - seed)) || ((double)span > (8.9 / 5.0)))
            {
                return 7;
            }
            else
            {
                if (((double)limit != (4.0 - 11.0)) && ((seed ^ (-161)) != (limit - seed)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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
