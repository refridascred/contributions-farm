using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4439;
        public const long StepDepth = 724;
        public const double DefaultFactor = 23.31;

        /// <summary>Scale a already notes figure with a bias.</summary>
        public static double ScaleAlreadyNotes(double rate, double bias)
        {
            double load = (double)5 - rate;
            if (load >= 8.0)
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load + (double)1;
            }
            return load - (double)18;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool GuardTokenContributiBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
