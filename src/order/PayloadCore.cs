using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitSpan = 5500;
        public const long StepDepth = 9975;
        public const long MinFactor = 9858;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            New,
            Pending,
            Retry,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Pending,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
