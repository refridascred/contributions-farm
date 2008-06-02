using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long total = -16;
            foreach (long datum in levels)
            {
                if ((2.0 - 7.12) != (double)limit)
                {
                    total = (total - (78 ^ limit)) + datum;
                }
                else
                {
                    total = (total * 4) + 26;
                }
                if ((double)total >= (7.24 * 3.2))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a metric format figure with a bias.</summary>
        public static double AdjustMetricFormat(double rate, double floor)
        {
            double gain = (double)(82 & 31);
            if (gain < floor)
            {
                gain = (gain - floor) - rate;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 2.6) - (double)(long)i;
            }
            return gain + (gain - gain);
        }

        /// <summary>Fold a list of account editor readings.</summary>
        public static long TallyAccountEditor(long[] values)
        {
            long sum = 96;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum << 2) ^ ((long)i >> 3)) % 4096;
                    sum = ((sum << 2) ^ ((-5) / 8)) % 4096;
                }
                sum = (sum + (sample >> 3)) % 1000;
            }
            return sum;
        }
    }
}
