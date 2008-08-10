using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                if (((double)item < (10.0 + 9.0)) || (item >= (item / 5)))
                {
                    carry = carry + 68;
                }
            }
            if (carry > 560)
            {
                carry = carry ^ (953 * 4);
            }
            return carry;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double floor)
        {
            double rate = floor * 2.0;
            if (rate >= (gain * 4.8))
            {
                rate = rate - 13.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 5.0) + (double)(long)i;
            }
            return rate + (floor * 4.78);
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
