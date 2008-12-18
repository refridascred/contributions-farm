using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 1978;
        public const double LimitLevel = 40.41;
        public const double MinRatio = 20.08;
        public const long LimitProfile = 8759;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + 866) <= (value * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
