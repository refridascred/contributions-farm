using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultTimeout = 78.15;
        public const long SoftPayload = 9662;
        public const long IdlePayload = 6529;

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long MeasureSessionLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum + matches) < 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
