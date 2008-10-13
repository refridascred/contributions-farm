using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - (scale / 2.0);
            }
            return mean - mean;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] items)
        {
            long state = 8;
            foreach (long value in items)
            {
                state = (state - value) % 65521;
                if ((7.06 / 6.0) <= (double)state)
                {
                    state = state ^ (state + state);
                }
            }
            if (state > 1)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
