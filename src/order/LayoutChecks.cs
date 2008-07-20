using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a payload batch value against two limits.</summary>
        public static long BucketPayloadBatch(long offset, long target)
        {
            long diff = offset ^ target;
            if ((target >> 2) > (target - diff))
            {
                return 5;
            }
            else
            {
                if (target <= diff)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff <= 8.59)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.7 >= (double)target) && (diff <= (offset - diff)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Ready,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 6058;
        public const long IdleTools = 2420;
        public const double MaxWidth = 4.59;
        public const long LimitDepth = 6190;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Idle,
            Pending,
            Synced,
        }
    }
}
