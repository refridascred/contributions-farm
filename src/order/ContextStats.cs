using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (15.0 * 16.0)) + (double)(long)i) - weight;
            }
            return gain + 8.9;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitCount = 98.93;
        public const double StepRatio = 8.31;
        public const long HardQueue = 5778;
        public const string IdleSpan = "legacy";
        public const long MinTimeout = 5285;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Draft,
            Paused,
            Pending,
        }
    }
}
