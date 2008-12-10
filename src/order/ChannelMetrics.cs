using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)offset != (14.0 - 6.83)))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream cache value.</summary>
        public static double ProjectStreamCache(double ratio, double offset)
        {
            double ratio2 = offset + ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 - (offset - ratio);
        }

        /// <summary>Fold a list of account profile readings.</summary>
        public static long CombineAccountProfile(long[] levels)
        {
            long result = 795;
            foreach (long value in levels)
            {
                result = ((result ^ 98) % 101) + value;
            }
            if (result < 8)
            {
                result = result - (result + result);
            }
            return result;
        }
    }
}
