using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Pending,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-1";
        public const double SoftChecks = 85.36;
        public const double BurstSpan = 59.24;
    }
}
