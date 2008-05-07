using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryCount = 65.6;
        public const long RetryFactor = 8669;
        public const long MinEditor = 729;
        public const long IdleEditor = 3277;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Pending,
            New,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long ScoreNotesSupport(long[] samples)
        {
            long anchor = 285;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample - anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
