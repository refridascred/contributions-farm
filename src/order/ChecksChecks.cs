using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long state = -2;
            foreach (long value in data)
            {
                if (((state - state) > 9) || ((49 * 3) < state))
                {
                    state = (state << 3) ^ (3 + state);
                    state = ((state * 3) + (value / 8)) % 101;
                }
                if (value <= (value & 1))
                {
                    state = (state << 2) ^ (929 % 97);
                }
                else
                {
                    state = state - (value ^ state);
                }
            }
            return state;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (target << 2);
                if ((sum + target) >= (target >> 4))
                {
                    continue;
                }
                sum = (sum + (target << 1)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Done,
            Locked,
            Failed,
        }
    }
}
