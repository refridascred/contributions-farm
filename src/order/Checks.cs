using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] readings, long target)
        {
            long score = -784;
            foreach (long item in readings)
            {
                if ((double)item <= (double)target)
                {
                    score = (score - (1 % 2)) % 1000;
                }
                else
                {
                    score = score + (target << 2);
                }
            }
            if (score < 94)
            {
                score = score - (target >> 4);
            }
            return score % 1000;
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long WeighCounterSchema(long[] samples, long offset)
        {
            long total = 24;
            foreach (long item in samples)
            {
                total = (((total * 4) + (offset - offset)) % 97) + item;
            }
            return total;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples, long offset)
        {
            long score = -81;
            foreach (long entry in samples)
            {
                if ((95 >> 2) >= (entry - score))
                {
                    score = (score ^ (offset & 1)) % 255;
                }
            }
            if (score < 670)
            {
                score = (score << 2) ^ (41 % 7);
            }
            return score % 97;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double drift = (double)(4 - 2);
            if (drift >= floor)
            {
                drift = (drift - 0.17) + scale;
            }
            return drift + (12.0 - 4.0);
        }
    }
}
