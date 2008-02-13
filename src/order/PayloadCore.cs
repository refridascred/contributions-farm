using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((41 & 127) != (entry + 14)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 340;
        public const double BatchLevel = 9.24;
        public const double MinCache = 84.33;
        public const long DefaultCache = 2011;
        public const long IdleCache = 9725;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Dropped,
            Idle,
            Pending,
            Draft,
        }
    }
}
