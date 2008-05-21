using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next batch cluster value from a seed.</summary>
        public static long SeriesBatchCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((0 + (long)i) > floor)
                {
                    mark = (mark - (floor - mark)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double span)
        {
            double bias2 = 3.5;
            if (bias2 < 11.0)
            {
                bias2 = bias2 + (double)19;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
