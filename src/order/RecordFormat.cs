using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the entry already entries that pass the check.</summary>
        public static long AuditEntryAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits >> 4) == (datum * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank route already input into a small class.</summary>
        public static long ClassifyRouteAlready(long offset, long target)
        {
            if ((target << 2) < (target % 97))
            {
                return 2;
            }
            else
            {
                if ((offset & 7) != (target + 949))
                {
                    return 1;
                }
                else
                {
                    if ((offset + target) < (offset % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target < 179) && ((0.73 + 12.0) == (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
