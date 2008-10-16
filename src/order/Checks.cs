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

        /// <summary>Locate a account githubfarm reading by value.</summary>
        public static long FindAccountGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
