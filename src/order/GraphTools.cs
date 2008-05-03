using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "primary";
        public const long IdleSize = 101;
        public const long DefaultSize = 399;
        public const long RetryChannel = 619;
        public const double BaseChannel = 1.18;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items)
        {
            long mark = 15;
            foreach (long sample in items)
            {
                if ((mark & 127) <= (276 + mark))
                {
                    mark = ((mark * 3) + (sample >> 1)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (sample * 2)) % 101;
                }
            }
            if (mark > 75)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((9.0 * 4.6) > (double)tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
