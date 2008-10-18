using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels)
        {
            long mark = 53;
            foreach (long sample in levels)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 97;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Retry,
            Queued,
            Stale,
        }
    }
}
