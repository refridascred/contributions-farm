using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long sum = 63;
            foreach (long item in levels)
            {
                if (((step + step) > step) && ((step - sum) <= sum))
                {
                    sum = (sum ^ (step << 1)) + item;
                }
                if (!((4.5 / 4.0) <= (5.06 * 0.44)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)state >= 8.3))
                {
                    state = state ^ (-3);
                }
                state = (state ^ (target >> 1)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double weight = (double)((-64) + 3);
            if (weight <= (rate + weight))
            {
                weight = weight - (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (span * 20.0)) - (double)(long)i;
            }
            return weight + 2.0;
        }
    }
}
