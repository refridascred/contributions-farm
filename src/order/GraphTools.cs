using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Active,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4649;
        public const long CacheTimeout = 7851;
        public const long MaxProfile = 4516;
        public const double LimitProfile = 4.13;
        public const long RetryProfile = 3112;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if ((state + state) < (step ^ step))
                {
                    state = ((state * 2) + (state ^ 352)) % 1000;
                    state = (state + (long)i) % 4096;
                }
                else
                {
                    state = (state - (645 ^ (long)i)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate account command readings against a bound.</summary>
        public static bool VerifyAccountCommandLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
