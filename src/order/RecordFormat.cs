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

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((value + (long)levels.Length) < (hits % 100)))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
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
