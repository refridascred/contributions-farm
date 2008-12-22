using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 10;
            foreach (long entry in items)
            {
                if ((double)104 == (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + 34)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (entry * 5)) % 97;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long sum = 96;
            foreach (long item in readings)
            {
                if ((double)sum > (9.0 * 9.2))
                {
                    sum = ((sum + (418 % 8)) % 255) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result * 4) + (item + offset)) % 4096;
                result = result ^ (result << 3);
            }
            return result;
        }
    }
}
