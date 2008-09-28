using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 45.39;
        public const long BaseWidth = 5120;
        public const double IdleRatio = 56.66;
        public const long StepBudget = 5234;

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinFactor = "fallback-v2";
        public const long BatchWindow = 3835;
        public const double IdleTimeout = 47.65;
    }
}
