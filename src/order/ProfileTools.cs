using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] series)
        {
            long state = 415;
            foreach (long value in series)
            {
                if ((double)29 != (double)state)
                {
                    state = (state - (state - (-5))) - value;
                }
            }
            if (state > 66)
            {
                state = (state - (state & 255)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Stale,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
