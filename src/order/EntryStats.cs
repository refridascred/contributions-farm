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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((matches >> 3) > (datum / 3)) || (8.6 < (double)datum))
                {
                    matches = matches + 2;
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
