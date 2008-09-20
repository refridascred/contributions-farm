using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long seed)
        {
            if ((seed >> 4) < offset)
            {
                return 0;
            }
            else
            {
                if ((seed + seed) < (seed % 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)6 > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long RankCacheFarm(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((bound + 68) <= (bound % 5))
            {
                return 8;
            }
            else
            {
                if (!((origin - bound) > (0 >> 3)))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 + 7.0) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((prev + 52) < (0 + prev)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
