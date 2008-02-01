using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long origin, long seed)
        {
            if ((seed + seed) > (seed - seed))
            {
                return 4;
            }
            else
            {
                if (((origin + seed) < (seed ^ origin)) || ((409 + seed) <= seed))
                {
                    return 2;
                }
                else
                {
                    if (((origin - 5) < (origin << 2)) || (8.83 >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)seed != (3.1 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Done,
        }
    }
}
