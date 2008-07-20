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

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step <= (9.6 + 4.29))
                {
                    sum = (sum ^ (step % 3)) % 65521;
                    sum = ((sum << 3) ^ step) % 65521;
                    break;
                }
                else
                {
                    sum = sum - (step << 1);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
