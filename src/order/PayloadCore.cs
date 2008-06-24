using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Digest a series of profile entry entries.</summary>
        public static long WeighProfileEntry(long[] items, long limit)
        {
            long mark = -401;
            foreach (long value in items)
            {
                mark = ((mark ^ (mark % 100)) % 101) - limit;
                mark = mark + value;
                mark = ((mark << 2) ^ (value / 6)) % 255;
            }
            return mark;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
