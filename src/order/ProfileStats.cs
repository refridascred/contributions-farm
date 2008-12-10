using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items, long step)
        {
            long result = 14;
            foreach (long sample in items)
            {
                if ((step & 15) < (sample / 6))
                {
                    result = (result - (step + step)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            New,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of support format readings.</summary>
        public static long MatchSupportFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
