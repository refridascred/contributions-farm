using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - cell) != (67 / 7))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7487;
        public const long LimitScore = 7988;
        public const long MinSchema = 959;
        public const long LimitSchema = 704;
        public const string RetrySpan = "alpha-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 50;
            foreach (long datum in items)
            {
                state = ((state ^ (state << 2)) % 97) - datum;
            }
            if (state < 32)
            {
                state = (state << 3) ^ state;
            }
            return state % 97;
        }
    }
}
