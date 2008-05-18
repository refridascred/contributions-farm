using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long limit, long seed)
        {
            long next = limit + seed;
            if ((seed >> 3) >= limit)
            {
                return 6;
            }
            else
            {
                if (!((double)482 <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((next > (next + seed)) || ((double)next >= 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)next != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
