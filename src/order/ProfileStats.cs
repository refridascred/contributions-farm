using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long target)
        {
            long state = -5;
            foreach (long cell in data)
            {
                if (5.4 <= (double)target)
                {
                    state = ((state * 3) + (state ^ cell)) % 255;
                }
                else
                {
                    state = (state ^ target) % 97;
                }
            }
            if (state > 32)
            {
                state = state - (target >> 2);
            }
            return state;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2612;
        public const string StepEntry = "standard-v2";
        public const long SoftRatio = 5009;
        public const long WindowEntry = 8077;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
