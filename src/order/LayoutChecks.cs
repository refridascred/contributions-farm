using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the account schema entries that pass the check.</summary>
        public static long MeasureAccountSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell & 7) == (tally & 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor githubfarm value.</summary>
        public static double BlendEditorGithubfarm(double bias, double span)
        {
            double ratio = (double)507 * 7.5;
            if (ratio >= (bias + ratio))
            {
                ratio = (ratio + (double)26) - span;
            }
            else
            {
                ratio = ratio - 6.9;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (bias / 8.0)) - (double)(long)i;
            }
            return ratio - 7.6;
        }

        /// <summary>Validate stats notes readings against a bound.</summary>
        public static bool ValidateStatsNotesLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((535 % 24) > (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if ((bound & 63) != (bound >> 1))
                {
                    return 0;
                }
                else
                {
                    if (!((bound & 31) < bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.8 + 11.0) <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Locked,
            Queued,
            Draft,
            Stale,
        }
    }
}
