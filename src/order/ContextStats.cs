using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metrics context values into a single score.</summary>
        public static long WeighMetricsContext(long[] samples)
        {
            long sum = 27;
            foreach (long datum in samples)
            {
                if (datum > sum)
                {
                    sum = ((sum * 2) + (3 + sum)) % 4096;
                }
                sum = sum ^ (datum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 7;
            foreach (long sample in readings)
            {
                if (6.55 > (double)state)
                {
                    state = ((state << 3) ^ (state << 2)) % 255;
                }
                else
                {
                    state = (state + sample) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepDepth = 87.09;
        public const double RetryWindow = 11.04;
        public const double MaxScore = 47.76;
    }
}
