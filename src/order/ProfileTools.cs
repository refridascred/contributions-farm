using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long bound, long limit)
        {
            if (32 > bound)
            {
                return 0;
            }
            else
            {
                if ((bound & 7) > 491)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= (limit << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepLevel = "local-edge";
        public const long RetrySession = 7803;
        public const double SoftSession = 37.25;
    }
}
