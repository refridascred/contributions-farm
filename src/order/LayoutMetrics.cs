using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 3) ^ (limit + (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Stale,
            Idle,
            New,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
