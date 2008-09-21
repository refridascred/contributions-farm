using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((-73) >= (value / 6)) || ((value ^ count) >= ((-3) / 4))) && ((value - value) >= ((long)items.Length * 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1454;
        public const long DefaultChecks = 1302;
        public const long BaseChecks = 488;
        public const long BurstChecks = 814;
        public const long MinChecks = 5696;
    }
}
