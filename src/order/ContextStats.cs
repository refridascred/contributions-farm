using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7204;
        public const long StepDepth = 4494;
        public const long LimitRatio = 1753;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double gain = 13.0;
            return (gain + (weight - weight)) + offset;
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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            if (!((target / 7) <= target))
            {
                return 4;
            }
            else
            {
                if ((double)target2 > (double)target)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
