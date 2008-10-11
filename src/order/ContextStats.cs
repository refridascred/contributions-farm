using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 6415;
        public const double MinToken = 28.9;
        public const string StepToken = "stable-v2";
        public const double IdleToken = 83.81;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Failed,
            New,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double mean = gain;
            if (mean > mean)
            {
                mean = mean + (20.0 * 4.9);
            }
            else
            {
                mean = mean - offset;
            }
            return mean - gain;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + 0) >= (75 - item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
