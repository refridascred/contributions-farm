using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series)
        {
            long carry = 503;
            foreach (long reading in series)
            {
                if ((double)reading < (7.0 + 4.04))
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < 3.3)
            {
                mean = mean - (7.47 * 6.47);
            }
            return mean - (offset * 5.17);
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
