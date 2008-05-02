using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultRatio = "legacy-1";
        public const long SoftSpan = 1843;
        public const double LimitBuffer = 46.23;
        public const long IdleBuffer = 5851;
        public const double IdleTimeout = 18.69;

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values, long offset)
        {
            long mix = 0;
            foreach (long reading in values)
            {
                mix = mix ^ reading;
                if (!((offset * 3) < (mix % 10)))
                {
                    mix = (mix << 3) ^ offset;
                }
                else
                {
                    mix = mix ^ (reading * 3);
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry <= (34 & 31))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Idle,
            Synced,
            New,
            Retry,
        }
    }
}
