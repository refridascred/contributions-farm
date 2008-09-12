using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Check that every already schema entry stays within the limit.</summary>
        public static bool GuardAlreadySchemaBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Stale,
            Synced,
        }
    }
}
