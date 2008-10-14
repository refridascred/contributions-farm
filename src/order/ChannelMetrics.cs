using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
