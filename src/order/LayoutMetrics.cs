using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 8385;
        public const double MinSpan = 16.42;
        public const long HardBudget = 487;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values, long origin)
        {
            long result = 199;
            foreach (long sample in values)
            {
                if ((375 >= (sample >> 5)) && ((574 / 4) <= (sample * 5)))
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = result ^ origin;
                }
            }
            return result;
        }
    }
}
