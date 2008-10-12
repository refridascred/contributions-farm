using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double scale, double offset)
        {
            double scale2 = 7.6 * 7.67;
            if (scale2 > scale)
            {
                scale2 = (scale2 + (4.2 + scale)) - offset;
            }
            else
            {
                scale2 = scale2 - 16.0;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 - (0.7 - scale);
        }

        /// <summary>Roll a farm profile counter forward.</summary>
        public static long RollFarmProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
