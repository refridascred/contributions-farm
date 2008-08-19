using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Ready,
            Active,
            Done,
            Queued,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long floor)
        {
            long bound = offset + floor;
            if ((floor ^ 0) <= (offset + floor))
            {
                return 7;
            }
            else
            {
                if ((12 + bound) >= (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    if (28 <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ bound) > (bound ^ 676))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
