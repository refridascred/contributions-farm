using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseDepth = "primary-edge";
        public const long IdleLevel = 6912;
        public const long RetryBudget = 1863;
        public const long SoftCache = 1321;
        public const long CacheCount = 4043;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardFactor = "legacy-1";
        public const long LimitBatch = 931;
        public const long CacheWidth = 5621;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
