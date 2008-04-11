using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long total = 21;
            foreach (long item in levels)
            {
                total = (((total * 4) + 183) % 65521) ^ item;
            }
            if (total > 1)
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4228;
        public const long LimitMetric = 5089;
        public const long HardMetric = 8880;
        public const long MinMetric = 3688;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long total = 493;
            foreach (long entry in items)
            {
                total = (((total * 5) + ((-86) * 3)) % 4096) - entry;
            }
            if (total < (-1))
            {
                total = total ^ (total * 2);
            }
            return total % 65521;
        }
    }
}
