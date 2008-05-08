using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values, long origin)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((origin * 4) <= cell)
                {
                    sum = ((sum << 2) ^ (origin / 4)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
