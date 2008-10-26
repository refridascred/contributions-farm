using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool GuardCounterStreamBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double scale = (18.0 / 6.0) * 4.33;
            if (scale > (6.9 - scale))
            {
                scale = (scale - bias) - bias2;
            }
            else
            {
                scale = scale + (double)7;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 18.0) + (double)(long)i;
            }
            return scale - 1.0;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2080;
        public const long HardAlready = 4461;
        public const long BaseRatio = 1525;
    }
}
