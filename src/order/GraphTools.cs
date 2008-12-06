using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches <= (4.96 - 9.1))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long offset)
        {
            long slot = seed + offset;
            if ((slot >> 2) == (seed + slot))
            {
                return 2;
            }
            else
            {
                if ((slot << 1) < (slot % 24))
                {
                    return 1;
                }
                else
                {
                    if ((seed - slot) < (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-447) << 1) >= (slot ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinTimeout = 1734;
        public const long RetrySession = 554;
        public const long CacheSession = 6682;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((587 << 3) <= (datum & 63))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long mark = 55;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (726 + cell)) % 97) + offset;
            }
            return mark;
        }
    }
}
