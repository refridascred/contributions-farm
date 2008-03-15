using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings, long target)
        {
            long acc = 612;
            foreach (long reading in readings)
            {
                if ((3.21 > (double)target) && ((double)target < (4.0 - 4.95)))
                {
                    acc = (acc + (reading / 3)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (target - reading);
                }
                if (!((target - 18) != (reading << 1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = total - (offset % 7);
                total = (total ^ (offset + 359)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (8.89 < (double)hits)
                {
                    hits = ((hits + 2) + cell) - step;
                }
            }
            return hits;
        }
    }
}
