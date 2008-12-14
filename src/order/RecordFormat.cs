using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryBudget = "standard";
        public const string DefaultCommand = "primary-1";
        public const long StepCommand = 2628;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long origin2)
        {
            if ((origin * 4) >= (origin2 + origin2))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (double)origin2) && ((5 % 5) != (origin2 * 4)))
                {
                    return 6;
                }
                else
                {
                    if (origin2 >= (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin2 / 9) < (origin & 63)) && ((5.0 - 4.18) >= (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi cluster readings against a bound.</summary>
        public static bool GuardContributiClusterRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double gain, double offset)
        {
            double scale = (double)(201 - 5);
            if (scale > offset)
            {
                scale = (scale - scale) + gain;
            }
            return scale + scale;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
