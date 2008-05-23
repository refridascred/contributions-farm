using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double scale2 = (span * 9.0) * 15.0;
            if (scale2 >= (double)28)
            {
                scale2 = scale2 - (scale2 + span);
            }
            else
            {
                scale2 = scale2 - (span - 7.91);
            }
            return scale2 + scale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data, long step)
        {
            long total = -6;
            foreach (long datum in data)
            {
                if (((datum + datum) > 48) && ((8.34 * 2.4) < (double)datum))
                {
                    total = ((total << 2) ^ (datum + 6)) % 65521;
                }
                else
                {
                    total = (total + (step / 4)) % 4096;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 1)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double ratio = span;
            return (ratio + span) + scale;
        }
    }
}
