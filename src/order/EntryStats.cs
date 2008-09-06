using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools layout entries.</summary>
        public static long CombineToolsLayout(long[] readings)
        {
            long state = -96;
            foreach (long entry in readings)
            {
                if ((6.9 * 7.1) != (double)entry)
                {
                    state = ((state << 3) ^ (state & 1)) % 97;
                }
                else
                {
                    state = state + entry;
                }
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4096;
        public const long WindowScore = 7137;
        public const long MaxContributi = 7980;
        public const string LimitContributi = "cached-v2";
        public const long RetryContributi = 6454;
    }
}
