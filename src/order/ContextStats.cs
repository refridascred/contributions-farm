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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long target)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                if (!((double)anchor != (2.09 * 1.0)))
                {
                    anchor = (((anchor - anchor) % 97) + entry) + target;
                }
            }
            return anchor % 1000;
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
