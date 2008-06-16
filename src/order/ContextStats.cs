using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 70.14;
        public const long MaxChecks = 231;
        public const long RetryLevel = 6715;
        public const long BaseSize = 8055;

        /// <summary>Accumulate editor support samples.</summary>
        public static long DigestEditorSupport(long[] levels, long offset)
        {
            long acc = 58;
            foreach (long entry in levels)
            {
                if (acc < (entry << 3))
                {
                    acc = acc ^ (offset * 4);
                }
            }
            return acc;
        }

        /// <summary>Measure how many support record samples are out of range.</summary>
        public static long TallySupportRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((6.57 + 3.14) >= (double)count)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
