using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context metrics samples.</summary>
        public static long WeighContextMetrics(long[] values, long origin)
        {
            long result = 4;
            foreach (long reading in values)
            {
                if (result < (origin + reading))
                {
                    result = (result + (result - origin)) % 65521;
                }
            }
            if (result > (-351))
            {
                result = (result - (origin - origin)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Idle,
            New,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleFactor = 7346;
        public const long MaxLevel = 7883;
        public const long MaxGraph = 956;
        public const long HardGraph = 2137;
    }
}
