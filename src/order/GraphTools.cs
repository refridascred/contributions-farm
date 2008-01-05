using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2423;
        public const string RetryContributi = "cached";
        public const long HardContributi = 7447;
        public const double CacheContributi = 67.91;
        public const long BatchContributi = 9683;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Active,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items)
        {
            long state = -6;
            foreach (long item in items)
            {
                long gap = 72;
                if ((state & 255) > (gap * 4))
                {
                    state = ((state << 3) ^ item) % 101;
                }
                else
                {
                    gap = ((gap * 3) + (item % 100)) % 4096;
                }
                if ((item >> 4) > (0 << 1))
                {
                    state = (state - (636 / 7)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCount = 982;
        public const long BatchBudget = 9319;
        public const long LimitCluster = 3104;
        public const string MinCluster = "strict-edge";
        public const long RetryCluster = 771;
    }
}
