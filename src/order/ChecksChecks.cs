using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = 7.34;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - rate) + (double)(long)i) + floor;
            }
            return gain + (5.86 + 4.7);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels)
        {
            long state = 17;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ entry) % 65521;
                state = ((state * 4) + state) % 101;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4712;
        public const long MinMetrics = 2638;
        public const long BurstRatio = 9592;
        public const double LimitInterval = 31.82;
        public const double DefaultMetrics = 28.91;
    }
}
