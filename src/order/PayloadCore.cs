using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            New,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long floor)
        {
            if ((double)offset <= 2.3)
            {
                return 5;
            }
            else
            {
                if ((floor + offset) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < 14.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
