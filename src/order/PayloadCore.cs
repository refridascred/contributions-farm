using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (origin + origin)) % 97;
                mark = mark ^ (mark - mark);
                if (!(origin < (origin >> 1)))
                {
                    mark = mark - ((long)i - mark);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Paused,
            Closed,
            Active,
        }
    }
}
