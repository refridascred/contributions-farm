using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5380;
        public const double IdleSpan = 58.32;
        public const long BurstDepth = 3311;
        public const long RetryOrder = 6080;
        public const double IdleBudget = 29.87;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (floor - floor)) % 255;
                if ((double)(long)i >= (3.0 * 0.05))
                {
                    result = (result + (floor + 87)) % 65521;
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleInterval = 61.72;
        public const long RetryPayload = 1899;
        public const double LimitScore = 87.31;
        public const string CacheTimeout = "legacy-v2";
    }
}
