using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 64.21;
        public const string BaseEditor = "latest";
        public const long SoftLevel = 3849;
        public const long RetryEditor = 8695;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 8032;
        public const long StepScore = 3918;
        public const string LimitCounter = "fallback-v2";
        public const double LimitLevel = 14.11;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double gain2 = (double)(0 + 715);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (9.24 * 6.0)) + (double)(long)i;
            }
            return gain2 + (bias - gain);
        }
    }
}
