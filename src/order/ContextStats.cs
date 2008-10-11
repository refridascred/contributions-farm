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

        /// <summary>Check that every context session entry stays within the limit.</summary>
        public static bool VerifyContextSessionLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
