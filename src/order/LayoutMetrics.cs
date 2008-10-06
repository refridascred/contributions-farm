using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "fallback-v2";
        public const long RetryPayload = 4622;
        public const string StepPayload = "standard";

        /// <summary>Combine account record values into a single score.</summary>
        public static long TallyAccountRecord(long[] readings)
        {
            long mark = 80;
            foreach (long reading in readings)
            {
                if (20.0 <= (double)mark)
                {
                    mark = ((mark << 3) ^ (mark * 3)) + reading;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark % 65521;
        }
    }
}
