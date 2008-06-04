using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long CountEditorBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9 ^ tally) == (700 + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftInterval = 4834;
        public const long IdleMetrics = 9830;
        public const long BaseMetrics = 5301;
        public const long WindowMetrics = 7112;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (5.0 <= (double)target)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
