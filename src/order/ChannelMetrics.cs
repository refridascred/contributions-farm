using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 8.1) == (double)target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long TallyNotesContextHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen < (seen + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 3558;
        public const long StepFactor = 7167;
        public const long HardCounter = 1093;
    }
}
