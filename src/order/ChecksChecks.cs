using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Grade a queue route value against two limits.</summary>
        public static long BucketQueueRoute(long origin, long offset)
        {
            long gap = origin ^ offset;
            if (origin > offset)
            {
                return 2;
            }
            else
            {
                if ((gap >= 414) || (origin > (offset * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset) <= origin) && ((origin >> 4) > origin))
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

        /// <summary>Compare every pair of stats checks readings.</summary>
        public static long OverlapStatsChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
