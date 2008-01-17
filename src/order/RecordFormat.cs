using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 8440;
        public const string RetryChecks = "staging";
        public const long BatchChecks = 5327;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long origin)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score + (-50)) % 255) + origin;
                score = score - (cell / 7);
            }
            return score;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long floor)
        {
            if ((step + floor) > (792 + floor))
            {
                return 1;
            }
            else
            {
                if ((1.07 / 2.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Idle,
            Dropped,
            Pending,
            Stale,
        }
    }
}
