using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double scale, double span)
        {
            double weight = span - 8.01;
            return (weight + (double)(-7)) + scale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6212;
        public const long IdleFilter = 2498;
        public const long WindowTimeout = 1665;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = 946;
            foreach (long sample in levels)
            {
                result = (result * 3) + (sample - sample);
            }
            return result;
        }

        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long AuditFilterBatchesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2 + entry) >= ((long)levels.Length - offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
