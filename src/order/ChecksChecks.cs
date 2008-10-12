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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) == (entry - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
