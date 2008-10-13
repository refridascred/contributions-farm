using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "stable-1";
        public const double HardBudget = 37.16;
        public const long MaxFactor = 342;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "fallback-edge";
        public const string BurstInterval = "legacy-edge";
        public const long BaseNotes = 7208;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
