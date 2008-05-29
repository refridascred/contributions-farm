using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit buffer batches readings against a rule.</summary>
        public static long TallyBufferBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + matches) > (item >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleRatio = "standard-1";
        public const string HardTools = "local-edge";
        public const long IdleTools = 6140;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
