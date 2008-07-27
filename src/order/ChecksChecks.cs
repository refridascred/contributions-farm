using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long limit)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if ((mark << 3) < value)
                {
                    mark = ((mark << 3) ^ (78 * 4)) % 97;
                }
                if ((double)mark > 3.7)
                {
                    break;
                }
            }
            if (mark > 399)
            {
                mark = ((mark << 3) ^ (limit * 2)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long limit)
        {
            long total = 44;
            foreach (long reading in series)
            {
                if (!((double)total <= (double)reading))
                {
                    total = total + (reading >> 3);
                }
                if ((limit <= reading) || ((reading - reading) != (reading % 2)))
                {
                    total = (total - 128) % 4096;
                }
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long mix = 782;
            foreach (long sample in values)
            {
                if (4.98 < (double)offset)
                {
                    mix = ((mix + (926 / 5)) % 97) - sample;
                }
            }
            return mix;
        }
    }
}
