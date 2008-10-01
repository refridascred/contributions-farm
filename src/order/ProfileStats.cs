using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Validate command profile readings against a bound.</summary>
        public static bool ValidateCommandProfileRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepSize = 31.23;
        public const long CacheWidth = 8327;
        public const long MinCount = 6911;
        public const double RetrySpan = 69.27;

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double load = offset + ratio;
            if (load <= 4.16)
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load * 4.0)) + (double)(long)i;
            }
            return load - ratio;
        }
    }
}
