using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "stable";
        public const long StepSpan = 3706;
        public const long CacheInterval = 7204;
        public const string BaseContext = "staging-1";
        public const long BaseLevel = 6399;

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 60.58;
        public const long BaseRatio = 1167;
        public const double BaseTimeout = 15.23;
        public const string WindowLevel = "primary-edge";
        public const long BaseRoute = 3493;

        /// <summary>Adjust a context buffer reading.</summary>
        public static double SmoothContextBuffer(double bias, double floor)
        {
            double ratio = (floor + floor) + (4.5 * 1.0);
            if (ratio > floor)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (bias / 7.0);
        }
    }
}
