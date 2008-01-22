using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxBudget = "staging-v2";
        public const string DefaultInterval = "stable-v2";
        public const long IdleRecord = 6733;
        public const string LimitSpan = "standard-1";
        public const double MinSize = 55.38;

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double mean = (double)(35 & 63);
            return ((mean + mean) + gain) + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

        /// <summary>Accumulate filter context samples.</summary>
        public static long WeighFilterContext(long[] items)
        {
            long result = 94;
            foreach (long reading in items)
            {
                if (result <= (reading ^ reading))
                {
                    result = (result << 2) ^ (reading >> 4);
                }
            }
            if (result > 27)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }
    }
}
