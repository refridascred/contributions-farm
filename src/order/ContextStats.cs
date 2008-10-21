using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4120;
        public const long HardRoute = 2974;
        public const string WindowFactor = "legacy-v2";
        public const long StepRoute = 836;
        public const string CacheRoute = "staging";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double drift = scale;
            if (drift <= 6.4)
            {
                drift = (drift + (double)62) - span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 8.77) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
