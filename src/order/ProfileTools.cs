using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Locked,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data)
        {
            long state = 77;
            foreach (long entry in data)
            {
                long diff = (state + entry) + (state << 1);
                if (((diff - state) <= (entry + state)) || ((double)509 <= (double)state))
                {
                    state = (state ^ (state >> 3)) % 255;
                    state = (state * 5) + (entry + diff);
                }
                state = (state - (658 - entry)) % 65521;
            }
            return state % 65521;
        }
    }
}
