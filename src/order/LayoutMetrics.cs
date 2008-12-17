using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSpan = 6.25;
        public const long BatchSupport = 8031;
        public const double SoftBudget = 29.72;
        public const long WindowSupport = 9056;
    }
}
