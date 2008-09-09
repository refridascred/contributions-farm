using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Done,
            Synced,
            Closed,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if ((9.0 * 2.5) >= (double)target)
                {
                    state = (state - target) % 97;
                    break;
                }
                if (!(((-650) > (873 + (long)i)) || ((state + (long)i) <= ((long)i + state))))
                {
                    state = (state * 2) + ((long)i + (long)i);
                    state = ((state << 3) ^ (target + 95)) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxSpan = 30.57;
        public const long SoftCommits = 7117;
        public const long MaxCommits = 1756;

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long CombineSchemaBatch(long[] values, long step)
        {
            long state = 95;
            foreach (long reading in values)
            {
                state = ((state ^ (state % 97)) % 255) - step;
                state = (state ^ (reading % 16)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Queued,
            Stale,
            Ready,
            Retry,
        }
    }
}
