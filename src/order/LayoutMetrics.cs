using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Synced,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (20.0 / 8.0))
            {
                ratio = (ratio + (scale + 3.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (scale + ratio)) - (double)(long)i;
            }
            return ratio - (8.0 + scale);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
