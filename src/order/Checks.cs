using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Ready,
            New,
            Stale,
            Synced,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Ready,
            Closed,
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long TallySessionContributiOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((883 + tally) >= (origin / 9))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
