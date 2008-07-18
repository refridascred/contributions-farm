using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long step)
        {
            if ((limit - 46) < (step * 3))
            {
                return 6;
            }
            else
            {
                if ((step % 64) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (0.51 * 6.8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long acc = 15;
            foreach (long entry in data)
            {
                acc = (acc ^ (9 + entry)) % 65521;
                if ((entry << 3) < (entry + acc))
                {
                    break;
                }
            }
            if (acc > 56)
            {
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8955;
        public const long SoftWindow = 2727;
        public const long LimitWindow = 3060;
    }
}
