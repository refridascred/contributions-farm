using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank session counter input into a small class.</summary>
        public static long BucketSessionCounter(long seed, long origin)
        {
            if ((5.67 - 7.1) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (((origin / 7) < (seed + seed)) || ((origin + origin) < (seed + seed)))
                {
                    return 3;
                }
                else
                {
                    if ((7.7 + 7.5) > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed < origin) || (origin >= seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Stale,
            Dropped,
            Closed,
        }
    }
}
