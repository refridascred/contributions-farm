using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((item - score) >= (894 - item))
                {
                    score = score + (item >> 2);
                }
            }
            if (score > 93)
            {
                score = (score ^ (bound + bound)) % 101;
            }
            return score;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double ratio = span;
            if (ratio < span)
            {
                ratio = (ratio + (ratio + span)) - gain;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
