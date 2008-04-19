using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the metric order series from a seed.</summary>
        public static long SeriesMetricOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Stale,
            Closed,
            Dropped,
            Draft,
        }
    }
}
