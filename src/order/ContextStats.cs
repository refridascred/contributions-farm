using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values, long floor)
        {
            long result = 360;
            foreach (long sample in values)
            {
                if ((result >= (result - result)) || ((double)sample >= (0.9 + 9.9)))
                {
                    result = ((result - ((-2) * 4)) % 97) - floor;
                }
                if (((result / 7) >= (-979)) || ((sample & 127) != (result << 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6651;
        public const double HardCount = 33.91;
        public const long RetrySchema = 8400;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 56.92;
        public const double StepRatio = 17.5;
        public const long WindowLevel = 3595;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
