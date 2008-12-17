using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next batches batch value.</summary>
        public static double ProjectBatchesBatch(double scale, double offset)
        {
            double drift = (double)(0 + 331);
            if (drift > (offset * 5.79))
            {
                drift = (drift - (double)8) - scale;
            }
            else
            {
                drift = drift - offset;
            }
            return drift - offset;
        }

        /// <summary>Adjust a commits window reading.</summary>
        public static double BlendCommitsWindow(double gain, double offset)
        {
            double load = (double)(41 & 127);
            return ((load - (double)89) + gain) + offset;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ (origin ^ score)) % 4096) - (long)i2;
                    score = (score << 2) ^ (90 >> 4);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
