using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long bound, long bound2)
        {
            if (!(((-84) % 16) >= bound))
            {
                return 3;
            }
            else
            {
                if ((bound - bound2) != (bound2 << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound2 > (13.0 * 3.28))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of checks editor readings.</summary>
        public static long OverlapChecksEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches > 8) || (matches <= (matches / 8))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((49 / 3) <= (count & 3)) && (((long)series.Length - value) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
