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

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
