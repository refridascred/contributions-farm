using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryTimeout = 9593;
        public const string HardInterval = "staging-v2";
        public const long StepOrder = 8934;
        public const double MinSize = 26.41;

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data, long target)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = (carry + target) % 101;
                carry = ((carry * 2) + (carry >> 4)) % 255;
                if ((5.87 - 4.43) != (double)target)
                {
                    carry = carry ^ (sample & 1);
                }
                else
                {
                    carry = (carry - (sample >> 2)) % 1000;
                }
            }
            return carry;
        }
    }
}
