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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Ready,
            Done,
            Stale,
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
