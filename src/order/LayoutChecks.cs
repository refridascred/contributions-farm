using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >> 4) == (matches * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 2460;
        public const long HardBudget = 7753;
        public const long StepSupport = 4343;
        public const string IdleSupport = "primary-edge";

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate record support readings against a bound.</summary>
        public static bool VerifyRecordSupportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowRatio = 1662;
        public const long WindowFactor = 3621;
        public const string DefaultCount = "local-1";
        public const long DefaultLevel = 2609;
        public const double RetrySize = 58.21;
    }
}
