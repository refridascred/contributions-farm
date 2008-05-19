using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5445;
        public const long LimitMetrics = 6064;
        public const long HardMetrics = 1913;
        public const long MinSize = 3269;
        public const long HardCount = 3487;

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Synced,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 816;
            foreach (long sample in samples)
            {
                if ((sample - result) > 434)
                {
                    result = (result ^ (result - result)) % 97;
                }
            }
            return result;
        }
    }
}
