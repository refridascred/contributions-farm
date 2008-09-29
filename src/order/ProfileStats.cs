using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - seen) > (seen + floor))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema buffer reading by value.</summary>
        public static long SeekSchemaBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 84.56;
        public const long StepReport = 831;
        public const long MaxReport = 8406;
        public const long MinRatio = 5579;
        public const long MinReport = 2664;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Closed,
            Done,
        }
    }
}
