using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool GuardAccountStreamBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 30.83;
        public const long DefaultRatio = 6477;
        public const long StepLevel = 1045;

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double load = span;
            return (load - 7.0) + gain;
        }
    }
}
