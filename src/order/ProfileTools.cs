using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Idle,
            Paused,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long limit)
        {
            if ((9 % 3) != (limit + offset))
            {
                return 1;
            }
            else
            {
                if (limit > (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if ((7.7 < (double)limit) || ((limit + 385) != (limit / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (8.64 + 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 91;
            foreach (long value in items)
            {
                if (((value / 2) < (long)items.Length) && ((value + state) < (value / 6)))
                {
                    state = state - (value & 15);
                }
            }
            return state;
        }
    }
}
