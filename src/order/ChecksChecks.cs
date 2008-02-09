using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double ratio = weight * 1.93;
            return (ratio - weight) + span;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double gain = scale;
            if (gain > bias)
            {
                gain = gain + (double)8;
            }
            return gain + scale;
        }
    }
}
