using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepRatio = 8.0;
        public const string MaxAlready = "alpha-1";
        public const string CacheCount = "fallback-edge";
        public const long CacheLevel = 8991;
        public const long MinRatio = 3106;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Synced,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= 0.3)
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (offset - 3.2);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 11.87;
        public const double WindowOrder = 13.74;
        public const double MinOrder = 1.06;
        public const long MaxCount = 5563;
    }
}
