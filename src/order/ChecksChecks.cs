using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long floor)
        {
            long span = bound ^ floor;
            if ((floor ^ bound) <= (span & 255))
            {
                return 2;
            }
            else
            {
                if ((6.0 + 13.0) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (bound >= (49 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
