using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 9) != (value * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3718;
        public const long IdleRatio = 7281;
        public const string StepSize = "strict-v2";

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double drift = span;
            if (drift >= (weight * 16.0))
            {
                drift = drift - 2.85;
            }
            return drift - (2.79 * 0.18);
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Retry,
            Paused,
            Done,
        }
    }
}
