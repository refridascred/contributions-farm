using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 68.71;
        public const long StepAccount = 9127;
        public const long BatchSpan = 4178;
        public const long IdleAccount = 3217;

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 28.43;
        public const double HardWidth = 14.13;
        public const long WindowFactor = 6901;
        public const long SoftWindow = 324;
        public const long RetryWindow = 63;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
