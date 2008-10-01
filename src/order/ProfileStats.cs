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

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i & 15)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
