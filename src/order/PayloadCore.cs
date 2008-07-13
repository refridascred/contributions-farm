using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a commits context sample.</summary>
        public static long SeekCommitsContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 97.72;
        public const long WindowWidth = 4209;
        public const double MinInterval = 19.56;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            Dropped,
            Active,
            Retry,
        }
    }
}
