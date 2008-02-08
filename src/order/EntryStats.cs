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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((239 ^ hits) < (item % 64))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long score = 8;
            foreach (long sample in data)
            {
                score = ((score ^ (1 + (long)data.Length)) % 4096) ^ sample;
            }
            return score;
        }
    }
}
