using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels, long step)
        {
            long result = 99;
            foreach (long entry in levels)
            {
                if ((entry & 7) > 43)
                {
                    result = result + (step ^ 208);
                }
            }
            return result % 1000;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
