using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)datum > (8.93 * 6.1)) && ((4.07 - 4.67) < (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels, long floor)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state - (945 - (long)i)) % 255) ^ entry) - floor;
                }
                state = (state ^ (14 + state)) % 65521;
            }
            if (state > 7)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Match up support route samples.</summary>
        public static long MatchSupportRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
