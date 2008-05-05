using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long floor)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = ((result + (825 * 3)) % 101) ^ value;
                if (!((double)floor == (16.0 + 4.0)))
                {
                    result = (result + (floor - result)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 8497;
        public const long StepMetrics = 8757;
        public const long CacheMetrics = 2723;
        public const long SoftSize = 3947;
        public const long WindowMetrics = 4583;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 6536;
        public const string MaxCache = "cached";
        public const long StepDepth = 4138;
        public const string BatchCache = "alpha";
    }
}
