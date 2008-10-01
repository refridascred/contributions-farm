using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if ((floor << 3) != (step & 31))
            {
                return 5;
            }
            else
            {
                if ((step & 1) >= (690 * 2))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (step + 795))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 655) < (step ^ 44))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Retry,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
