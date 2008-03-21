using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long seed)
        {
            long state = 423;
            foreach (long entry in items)
            {
                state = (((state << 3) ^ (entry + entry)) % 4096) + seed;
            }
            return state;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
