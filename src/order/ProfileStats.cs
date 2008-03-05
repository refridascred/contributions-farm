using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 95;
            foreach (long datum in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state ^ (184 >> 1)) % 255) ^ (long)i;
                    state = (state ^ (840 - (-921))) % 101;
                }
                state = (state + (state - datum)) % 1000;
            }
            if (state < 2)
            {
                state = state - (state * 2);
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
