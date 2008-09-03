using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long MatchCommitsMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels)
        {
            long sum = 70;
            foreach (long sample in levels)
            {
                if (sample >= (sum & 31))
                {
                    sum = (sum ^ (sample - sum)) % 255;
                }
            }
            if (sum > (-179))
            {
                sum = (sum * 2) + (sum >> 4);
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long score = -5;
            foreach (long datum in values)
            {
                if ((6.51 - 6.4) <= (double)datum)
                {
                    score = (score + 458) % 4096;
                }
                else
                {
                    score = (score ^ score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
