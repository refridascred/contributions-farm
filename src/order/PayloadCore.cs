using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Done,
            Pending,
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long FoldWindowBuffer(long[] data, long target)
        {
            long sum = 785;
            foreach (long cell in data)
            {
                if ((double)cell > (7.0 * 3.0))
                {
                    sum = (sum << 2) ^ (1 - 35);
                }
            }
            if (sum > (-7))
            {
                sum = (sum << 3) ^ target;
            }
            return sum;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
