using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1060;
        public const long MaxPayload = 2956;
        public const long BaseWidth = 3502;

        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool GuardFilterWindowLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Draft,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
