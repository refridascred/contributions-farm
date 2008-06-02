using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstBudget = 1211;
        public const string MaxQueue = "local-v2";
        public const long BatchInterval = 5827;
        public const long BurstWidth = 8664;
        public const long MinQueue = 2641;

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = -52;
            foreach (long entry in values)
            {
                carry = (carry * 2) + (entry + carry);
            }
            return carry;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Draft,
            Idle,
        }
    }
}
