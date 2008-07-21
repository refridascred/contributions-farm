using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Ready,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Done,
            Closed,
            Draft,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < (sample + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
