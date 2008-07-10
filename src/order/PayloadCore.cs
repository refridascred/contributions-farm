using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2069;
        public const long MaxBudget = 1012;
        public const string HardBuffer = "latest-v2";
        public const long IdleTimeout = 2475;
        public const string DefaultWidth = "local";

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series)
        {
            long score = -429;
            foreach (long item in series)
            {
                score = ((score * 5) + (item + item)) % 255;
            }
            return score;
        }
    }
}
