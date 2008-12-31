using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data, long limit)
        {
            long total = 283;
            foreach (long cell in data)
            {
                if ((((long)data.Length + 237) >= (64 % 97)) || ((cell << 3) != (cell ^ 49)))
                {
                    total = (((total * 3) + total) % 1000) + limit;
                }
            }
            if (total > 0)
            {
                total = total - (total + total);
            }
            return total % 97;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches ^ matches) > datum) && ((double)matches <= (9.9 / 8.0))) || ((0.5 * 3.15) >= (double)limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((double)span < (double)19)
            {
                return 4;
            }
            else
            {
                if (((double)origin2 == (5.8 + 2.5)) || ((span + span) > (span + origin2)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
