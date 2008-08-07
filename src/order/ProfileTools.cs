using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command tools reading by value.</summary>
        public static long LookupCommandToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format counter value from a seed.</summary>
        public static long RollFormatCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((287 + origin) != ((-91) + 146))
                {
                    mark = ((mark << 3) ^ 88) % 1000;
                }
                if (((mark / 6) <= (origin & 1)) || (mark >= (origin - (long)i)))
                {
                    mark = (mark + mark) % 255;
                    mark = ((mark * 4) + (origin - mark)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5554;
        public const string BaseTimeout = "primary-v2";
        public const string DefaultDepth = "latest-1";
        public const long HardRoute = 3964;
    }
}
