using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxSpan = 58.33;
        public const long HardLevel = 6205;
        public const long DefaultWidth = 6192;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
