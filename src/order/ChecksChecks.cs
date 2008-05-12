using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long seed)
        {
            if ((237 + seed) <= step)
            {
                return 6;
            }
            else
            {
                if (((seed * 2) == (seed & 3)) || ((step * 3) > seed))
                {
                    return 0;
                }
                else
                {
                    if (9.3 >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6.42 * 9.0) <= (double)seed) && ((4.0 + 19.0) == (double)step))
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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Idle,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Draft,
            Closed,
            Locked,
        }
    }
}
