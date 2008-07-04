using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next farm profile value.</summary>
        public static double ProjectFarmProfile(double scale, double span)
        {
            double gain = scale;
            if (gain >= (gain / 9.0))
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (5.47 - span);
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long limit)
        {
            long mark = 4;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ reading) + limit;
            }
            return mark;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double mean = (double)(0 - (-8));
            if (mean > (double)3)
            {
                mean = (mean + (double)768) + floor;
            }
            else
            {
                mean = mean + (mean - weight);
            }
            return mean + (1.0 + weight);
        }
    }
}
