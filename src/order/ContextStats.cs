using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long LookupBatchesPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepRatio = 8391;
        public const double WindowCache = 54.12;
        public const long LimitCache = 9119;
        public const double SoftScore = 61.64;
        public const long RetryTimeout = 8525;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Ready,
            Stale,
        }
    }
}
