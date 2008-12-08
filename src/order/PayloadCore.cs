using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a checks metric value against two limits.</summary>
        public static long ClassifyChecksMetric(long offset, long step)
        {
            long next = offset + step;
            if ((next - step) > (next * 3))
            {
                return 5;
            }
            else
            {
                if ((next << 3) >= 306)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Dropped,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Classify a window tools pair into a bucket.</summary>
        public static long BucketWindowTools(long seed, long offset)
        {
            if (((offset >> 5) <= seed) && ((offset + seed) > (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (seed <= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
