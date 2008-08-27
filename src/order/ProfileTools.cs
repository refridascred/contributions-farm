using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double mean = offset;
            if (mean < (bias + offset))
            {
                mean = mean + (double)958;
            }
            else
            {
                mean = mean + (double)77;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)83) - (double)(long)i;
            }
            return mean - (0.1 / 2.0);
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((bound > (tally << 3)) && ((tally * 2) <= (sample & 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics commits readings.</summary>
        public static long MatchMetricsCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 101) ^ datum;
                anchor = anchor - (2 % 8);
                if ((anchor * 2) >= (origin >> 1))
                {
                    anchor = (anchor + ((-8) / 7)) % 97;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
            }
            return anchor;
        }
    }
}
