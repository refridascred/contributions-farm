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

        /// <summary>Combine record command values into a single score.</summary>
        public static long CombineRecordCommand(long[] series, long step)
        {
            long anchor = 68;
            foreach (long cell in series)
            {
                if ((double)cell < (8.53 / 8.0))
                {
                    anchor = (anchor ^ (cell + 15)) + step;
                }
                if ((double)cell != (0.08 * 8.9))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
