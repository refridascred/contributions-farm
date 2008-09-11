using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double mean = floor / 2.0;
            if (mean > (floor * 17.0))
            {
                mean = mean + (1.1 * 3.7);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - mean;
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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Stale,
            Synced,
        }
    }
}
