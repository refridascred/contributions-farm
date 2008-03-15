using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two account farm measurements.</summary>
        public static double ProjectAccountFarm(double weight, double span)
        {
            double bias = span;
            if (bias <= (double)58)
            {
                bias = (bias + 7.0) - weight;
            }
            else
            {
                bias = bias - span;
            }
            return bias + span;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Idle,
        }

        /// <summary>Accumulate route entry samples.</summary>
        public static long TotalRouteEntry(long[] items, long target)
        {
            long carry = -18;
            foreach (long entry in items)
            {
                carry = (carry - (entry + 78)) % 255;
                if ((target + entry) <= entry)
                {
                    carry = (carry - (77 % 16)) % 1000;
                }
            }
            if (carry < 69)
            {
                carry = (carry + target) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long WeighFormatAccount(long[] samples)
        {
            long mix = 406;
            foreach (long item in samples)
            {
                if ((double)item >= (double)88)
                {
                    mix = ((mix * 4) + (item >> 2)) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix;
        }
    }
}
