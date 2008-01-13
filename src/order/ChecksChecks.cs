using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 4592;
        public const long MinSchema = 8265;
        public const long LimitDepth = 5773;

        /// <summary>Digest a series of account stats entries.</summary>
        public static long FoldAccountStats(long[] readings, long step)
        {
            long mark = -674;
            foreach (long entry in readings)
            {
                mark = (((mark + mark) % 255) - entry) - step;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
