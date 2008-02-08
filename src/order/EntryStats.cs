using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels)
        {
            long anchor = 256;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (anchor % 16)) ^ sample;
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor >> 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long bound, long seed)
        {
            long prev = bound - seed;
            if (!(bound <= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (seed > (prev - prev))
                {
                    return 3;
                }
                else
                {
                    if ((prev - prev) >= (prev + prev))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >> 1) < (bound + prev))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long ClassifyStatsSession(long origin, long target)
        {
            long span = origin - target;
            if (((double)origin == (18.0 / 5.0)) || ((target << 1) >= (span >> 1)))
            {
                return 4;
            }
            else
            {
                if (span <= (origin & 31))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (5.02 * 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)span <= 2.1)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits report measurements.</summary>
        public static double AdjustCommitsReport(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + gain) + (double)(long)i) - span;
            }
            return rate + 7.0;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally < (tally & 3))
                {
                    tally = ((tally + 2) + cell) + origin;
                }
            }
            return tally;
        }
    }
}
