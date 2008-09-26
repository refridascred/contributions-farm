using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] data)
        {
            long score = 117;
            foreach (long value in data)
            {
                if (score < (-21))
                {
                    score = (score - (value % 60)) % 101;
                }
            }
            if (score > 15)
            {
                score = (score ^ (score * 2)) % 97;
            }
            return score;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
