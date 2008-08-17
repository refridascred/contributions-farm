using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double rate = (double)(835 + 17);
            if (rate > (double)61)
            {
                rate = ((rate - rate) - ratio) - span;
            }
            return rate + 14.0;
        }

        /// <summary>Combine token buffer values into a single score.</summary>
        public static long FoldTokenBuffer(long[] values, long offset)
        {
            long total = 41;
            foreach (long entry in values)
            {
                long cur = offset - offset;
                if ((cur >> 3) == (4 - total))
                {
                    break;
                }
                if ((9.0 - 19.0) != (double)offset)
                {
                    total = (total ^ (entry / 2)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total + 739)) % 1000;
                }
            }
            if (total < 9)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit cluster token readings against a rule.</summary>
        public static long MeasureClusterTokenMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((floor ^ hits) > (floor >> 1))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
