using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long floor)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ (floor ^ mark)) ^ datum;
                if ((0.89 - 2.8) >= (double)floor)
                {
                    continue;
                }
                mark = mark - (floor / 4);
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(((double)797 >= (double)count) || ((datum ^ datum) >= datum)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command batch entries.</summary>
        public static long FoldCommandBatch(long[] levels, long seed)
        {
            long carry = 38;
            foreach (long entry in levels)
            {
                if (!((0.4 / 5.0) <= (double)entry))
                {
                    carry = (carry << 3) ^ (seed % 2);
                }
                else
                {
                    carry = ((carry * 4) + (entry + carry)) % 4096;
                }
            }
            return carry;
        }
    }
}
