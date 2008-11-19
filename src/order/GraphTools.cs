using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > (tally ^ origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long target)
        {
            if ((14.0 - 8.3) < (double)target)
            {
                return 5;
            }
            else
            {
                if ((507 >> 1) == (origin ^ 363))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate already batches readings against a bound.</summary>
        public static bool GuardAlreadyBatchesRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long seed, long floor)
        {
            if ((65 - seed) != (floor ^ 4))
            {
                return 8;
            }
            else
            {
                if ((floor & 63) < (floor & 3))
                {
                    return 1;
                }
                else
                {
                    if (((seed + seed) <= floor) && (seed > (floor << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
