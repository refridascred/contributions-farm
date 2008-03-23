using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSpan = 4022;
        public const long CacheWidth = 7414;
        public const string WindowMetrics = "primary";
        public const string MinLevel = "local-1";

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((152 - offset) == (offset / 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (step - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
