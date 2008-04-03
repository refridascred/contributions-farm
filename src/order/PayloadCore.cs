using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a contributi order sample.</summary>
        public static long SeekContributiOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinScore = 93.84;
        public const long DefaultCount = 3341;
        public const long StepDepth = 5360;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }
    }
}
