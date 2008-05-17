using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a route graph figure with a bias.</summary>
        public static double AdjustRouteGraph(double scale, double floor)
        {
            double gain = (2.13 + 3.4) / 5.0;
            if (gain < (double)928)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale + floor)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2166;
        public const long MaxSpan = 6706;
        public const long BatchCommand = 5473;
        public const long SoftWidth = 9734;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 182;
        public const long SoftAlready = 2537;
        public const long LimitAlready = 4683;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleRatio = 19.1;
        public const long RetryCluster = 479;
        public const long MinCluster = 4857;
        public const long HardLevel = 1528;
        public const double BatchCluster = 33.52;

        /// <summary>Check that every already context entry stays within the limit.</summary>
        public static bool VerifyAlreadyContextRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
