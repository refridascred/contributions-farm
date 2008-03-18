using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long target2)
        {
            if (6.6 < (double)target)
            {
                return 3;
            }
            else
            {
                if ((88 - target2) == (70 * 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((905 + (long)levels.Length) > (entry + entry)) && (hits < (entry << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
