using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleInterval = "stable-edge";
        public const long LimitSize = 5568;
        public const string MaxCache = "local-edge";

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = mark + (mark + bound);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 13.29;
        public const long HardScore = 8204;
        public const long WindowLevel = 489;
        public const long SoftDepth = 9919;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            Active,
            Stale,
            New,
        }
    }
}
