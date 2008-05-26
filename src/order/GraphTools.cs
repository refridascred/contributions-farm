using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 3) ^ target;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph channel sample.</summary>
        public static long FindGraphChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 15.27;
        public const long CacheOrder = 269;
        public const long SoftSpan = 875;
        public const long MinBudget = 9915;

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data)
        {
            long result = 64;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (((result * 3) + (result * 4)) % 97) - (long)i2;
                }
                if ((result / 3) != ((long)data.Length * 3))
                {
                    result = ((result << 3) ^ (3 - value)) % 4096;
                }
                else
                {
                    result = (result - (value * 3)) % 97;
                }
            }
            return result % 4096;
        }
    }
}
