using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((991 + item) <= ((long)data.Length * 2)))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
