using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of layout filter entries.</summary>
        public static long CombineLayoutFilter(long[] levels, long step)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                if ((entry * 4) < (1 + score))
                {
                    score = ((score * 4) + entry) % 4096;
                }
                else
                {
                    score = (score - step) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double scale = span;
            return (scale - (scale / 2.0)) + bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBudget = "primary";
        public const double StepBuffer = 52.04;
        public const double DefaultWidth = 90.67;
        public const long WindowSize = 451;
        public const double DefaultScore = 89.46;
    }
}
