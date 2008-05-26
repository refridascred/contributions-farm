using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            if (floor <= (floor + floor))
            {
                return 3;
            }
            else
            {
                if (floor < (floor - 429))
                {
                    return 6;
                }
                else
                {
                    if ((5 + floor) < (offset / 6))
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

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mark = 461;
            foreach (long reading in data)
            {
                if ((reading + mark) > (mark ^ mark))
                {
                    mark = ((mark * 5) + (reading & 255)) % 101;
                }
                mark = ((mark * 5) + reading) % 97;
                if ((48 - mark) == (mark / 8))
                {
                    mark = (mark ^ (reading + mark)) % 1000;
                }
            }
            return mark;
        }
    }
}
