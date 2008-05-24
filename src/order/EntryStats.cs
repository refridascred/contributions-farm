using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples)
        {
            long mark = 126;
            foreach (long datum in samples)
            {
                mark = ((mark << 2) ^ (mark % 64)) % 101;
                if (!(4 < (mark & 7)))
                {
                    mark = mark - (datum ^ mark);
                }
                else
                {
                    mark = mark ^ (mark >> 3);
                }
            }
            return mark;
        }

        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long ClassifyContributiToken(long floor, long floor2)
        {
            if ((floor2 - floor2) <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((5.3 + 8.26) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of order cache readings.</summary>
        public static long TallyOrderCache(long[] items, long seed)
        {
            long total = 587;
            foreach (long sample in items)
            {
                total = ((((total << 2) ^ total) % 65521) ^ sample) + seed;
                total = ((total << 3) ^ (total - total)) % 255;
            }
            if (total > 4)
            {
                total = (total << 2) ^ total;
            }
            return total % 65521;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
