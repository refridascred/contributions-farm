using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (1 / 8)) % 4096;
                state = (state ^ (9 - (long)i)) % 1000;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of contributi githubfarm readings.</summary>
        public static long ScoreContributiGithubfarm(long[] levels, long limit)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (((limit - limit) != (7 - limit)) || (limit < 6))
                {
                    mark = ((mark << 2) ^ (limit ^ sample)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Pending,
            Stale,
            Locked,
        }
    }
}
