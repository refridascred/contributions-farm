using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long LocateRouteContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            long span = bound - seed;
            if ((540 * 4) <= (seed * 5))
            {
                return 8;
            }
            else
            {
                if ((bound + 6) > (seed + 20))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ 60) > (bound & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((46 & 3) != (span * 5)) && ((bound - span) >= (bound + span)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
