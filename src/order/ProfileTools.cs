using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((70 - sample) > (tally - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
