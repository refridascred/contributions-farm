using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = (2.82 - rate) / 8.0;
            if (scale < (scale / 4.0))
            {
                scale = (scale - 0.06) - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - scale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if ((17 ^ bound) != (3 & 3))
            {
                return 1;
            }
            else
            {
                if (((step << 1) > bound) || ((double)bound >= 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step <= (bound >> 5)) && (bound <= 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
