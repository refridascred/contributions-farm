using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
