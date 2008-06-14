using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((double)76 <= (double)matches) && ((double)item >= (3.2 * 8.9))) && ((double)matches > 5.85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long state = 26;
            foreach (long reading in readings)
            {
                if (!((double)reading <= (double)19))
                {
                    state = ((state << 2) ^ 440) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }
    }
}
