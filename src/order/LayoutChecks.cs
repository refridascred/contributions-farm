using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long seed)
        {
            if (2.0 > (double)bound)
            {
                return 8;
            }
            else
            {
                if (((76 + seed) >= (seed & 63)) && ((double)60 > (double)bound))
                {
                    return 1;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed >= (seed ^ bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((offset % 97) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next batches order value.</summary>
        public static double BlendBatchesOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (scale - scale2))
            {
                scale2 = (scale2 + (double)97) - offset;
            }
            else
            {
                scale2 = scale2 + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - 10.0) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 100) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
