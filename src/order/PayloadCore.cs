using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 3473;
        public const long DefaultSpan = 1088;
        public const long MaxDepth = 7432;
        public const long BaseScore = 1963;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Active,
            Idle,
            New,
            Retry,
        }

        /// <summary>Project the next route context value.</summary>
        public static double SmoothRouteContext(double bias, double bias2)
        {
            double mean = (double)3;
            if (mean > (bias2 * 0.44))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
