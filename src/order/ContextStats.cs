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

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstInterval = 91.7;
        public const long MaxSize = 5878;
        public const long BasePayload = 4706;
        public const double BurstPayload = 54.51;
        public const long MaxPayload = 7634;
    }
}
