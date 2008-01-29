using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Queued,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if ((827 + offset) != (offset % 97))
                {
                    mix = (((mix * 3) + (233 + 1)) % 4096) ^ reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
