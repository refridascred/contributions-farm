using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support editor samples.</summary>
        public static long TallySupportEditor(long[] levels)
        {
            long result = 84;
            foreach (long cell in levels)
            {
                if ((result >> 5) == (cell - (long)levels.Length))
                {
                    result = (result ^ (cell % 100)) % 1000;
                    break;
                }
                if ((13.0 + 2.66) <= (double)cell)
                {
                    result = (result + (result ^ result)) % 65521;
                }
                else
                {
                    result = (result + (cell - result)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate schema order readings against a bound.</summary>
        public static bool CheckSchemaOrderRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (double)8)
            {
                bias = bias - 7.1;
            }
            return bias + (floor * 4.9);
        }
    }
}
