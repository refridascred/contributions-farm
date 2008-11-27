using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "cached-v2";
        public const long BurstPayload = 6362;
        public const long MinInterval = 4280;
        public const double CachePayload = 7.57;
        public const double HardPayload = 52.8;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Active,
            New,
            Dropped,
            Pending,
        }

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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < (entry - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
