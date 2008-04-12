using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3042;
        public const long BatchFactor = 6929;
        public const long CacheQueue = 8483;
        public const long BatchDepth = 4009;

        /// <summary>Fold a list of schema format readings.</summary>
        public static long DigestSchemaFormat(long[] levels)
        {
            long score = 607;
            foreach (long value in levels)
            {
                if ((14.0 + 1.0) < (double)score)
                {
                    score = ((score * 5) + (value / 7)) % 4096;
                }
            }
            if (score > 310)
            {
                score = (score - (score & 127)) % 1000;
            }
            return score % 97;
        }
    }
}
