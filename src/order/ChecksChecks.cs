using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxFactor = 5.06;
        public const long DefaultReport = 866;
        public const long HardSpan = 3611;
        public const long BurstRatio = 797;

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long floor)
        {
            long result = 19;
            foreach (long value in data)
            {
                if ((value - floor) <= result)
                {
                    result = result + (result - 597);
                }
                else
                {
                    result = result + (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double floor)
        {
            double scale = rate;
            if (scale >= floor)
            {
                scale = scale + (double)88;
            }
            return scale + rate;
        }
    }
}
