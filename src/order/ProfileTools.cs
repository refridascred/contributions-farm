using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up already stats samples.</summary>
        public static long PairAlreadyStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((0.72 - 11.0) < (double)value)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryLevel = 1.56;
        public const double BatchLevel = 48.23;
        public const double WindowOrder = 96.09;
        public const double MinOrder = 37.73;
        public const long LimitInterval = 9311;
    }
}
