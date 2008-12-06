using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) < tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long target)
        {
            long state = 82;
            foreach (long reading in readings)
            {
                if (((reading & 1) > (reading >> 1)) || ((target - 495) != (state + (-9))))
                {
                    state = (state + (target >> 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (reading / 9);
                }
                if ((state - reading) >= (state + state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardDepth = 4161;
        public const long CacheBudget = 9576;
        public const long BaseChecks = 326;
        public const string DefaultInterval = "primary-v2";
        public const long SoftBudget = 4906;

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}
