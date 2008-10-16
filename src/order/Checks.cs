using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                acc = (acc + acc) % 255;
                if ((datum ^ datum) != (datum + datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine commits batch values into a single score.</summary>
        public static long WeighCommitsBatch(long[] levels, long origin)
        {
            long state = 1;
            foreach (long entry in levels)
            {
                if ((entry + origin) < entry)
                {
                    state = (state ^ (state + entry)) % 4096;
                }
                if (entry >= (state - origin))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of metric route readings.</summary>
        public static long TallyMetricRoute(long[] levels, long floor)
        {
            long mix = 8;
            foreach (long reading in levels)
            {
                if (!(((mix & 31) < ((-333) + reading)) && ((long)levels.Length < 824)))
                {
                    mix = (mix + (reading >> 2)) % 1000;
                }
                mix = mix + (mix + 75);
            }
            if (mix < (-2))
            {
                mix = (mix << 3) ^ floor;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total - total) % 4096;
                if ((15.0 - 6.0) < (double)total)
                {
                    total = (total + (target >> 2)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) <= datum)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
