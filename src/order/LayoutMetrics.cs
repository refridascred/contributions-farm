using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) != (count / 6))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Active,
            Locked,
            Dropped,
            Queued,
        }
    }
}
