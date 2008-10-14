using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long target)
        {
            if (!((target >> 3) < origin))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) < (target * 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (8.52 - 3.9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
