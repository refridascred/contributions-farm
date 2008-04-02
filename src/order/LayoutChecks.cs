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

        /// <summary>Validate githubfarm already readings against a bound.</summary>
        public static bool GuardGithubfarmAlreadyLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (((5 & 255) >= floor) || ((floor - limit) <= (edge * 3)))
            {
                return 7;
            }
            else
            {
                if (((6.8 - 9.15) < (double)limit) || ((floor + edge) < (edge - edge)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (20.0 + 9.7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
