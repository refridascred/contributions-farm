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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Fold a list of command filter readings.</summary>
        public static long TotalCommandFilter(long[] levels)
        {
            long state = 482;
            foreach (long cell in levels)
            {
                if ((double)cell < (5.86 + 5.71))
                {
                    state = (state + (0 << 2)) % 4096;
                }
                else
                {
                    state = state ^ (state + state);
                }
            }
            return state;
        }

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
