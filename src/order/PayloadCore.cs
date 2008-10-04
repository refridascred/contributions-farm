using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySize = 7914;
        public const long HardProfile = 2363;
        public const long MaxProfile = 588;
        public const long CacheProfile = 3047;
        public const long IdleSize = 4553;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) < (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 562;
        public const long CacheRatio = 2922;
        public const long RetryPayload = 7796;
        public const long MinLevel = 2336;
        public const double DefaultPayload = 94.25;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 483;
        public const double BatchWindow = 25.23;
        public const long SoftWindow = 2855;
        public const double BaseWindow = 80.52;
        public const long IdleFactor = 2516;
    }
}
