using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepDepth = 9184;
        public const long StepLevel = 50;
        public const string BatchTimeout = "strict-v2";
        public const long MinAlready = 1106;
        public const long CacheAlready = 9739;

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
