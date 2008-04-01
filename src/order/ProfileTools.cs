using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long seed)
        {
            if ((bound >> 2) < (seed - 0))
            {
                return 7;
            }
            else
            {
                if ((seed % 2) <= (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if (!(bound > (bound / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 4) <= (bound << 3)) && ((38 * 2) >= (bound - bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset == (3.6 / 7.0))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
