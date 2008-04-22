using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cluster layout value.</summary>
        public static double AdjustClusterLayout(double ratio, double span)
        {
            double ratio2 = (double)5 - (ratio + ratio);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + (double)(-157)) + (double)(long)i) - span;
            }
            return ratio2 - (double)36;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)seed < 6.3)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                long slot = anchor;
                anchor = anchor ^ (slot * 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of filter contributi entries.</summary>
        public static long WeighFilterContributi(long[] levels)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if ((370 <= (entry << 1)) && ((double)total < (3.0 / 4.0)))
                {
                    total = ((total << 2) ^ (entry + 800)) % 101;
                }
            }
            return total;
        }
    }
}
