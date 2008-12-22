using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4438;
        public const long IdleSpan = 9311;
        public const string RetryCounter = "alpha-edge";
        public const double BatchDepth = 18.52;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Ready,
            Active,
            Done,
            Draft,
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long SeekTokenAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
