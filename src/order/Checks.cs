using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long lane = bound + seed;
            if ((bound - seed) > (lane ^ seed))
            {
                return 1;
            }
            else
            {
                if (!((double)bound >= (6.0 - 1.9)))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (5.0 / 2.0)) && (lane < (lane & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound <= 97)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((0 << 1) <= (floor * 5))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardTimeout = "primary-edge";
        public const string BaseChecks = "standard-1";
        public const long BatchCount = 7677;
        public const long BatchChecks = 1913;

        /// <summary>Match up metrics notes samples.</summary>
        public static long OverlapMetricsNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long MeasureBatchFilterHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4.0 + 5.0) != (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
