using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double drift = 0.41;
            return ((drift - (double)7) + scale) + floor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total << 3) ^ bound) % 255) ^ (long)i2;
                }
                if (58 > (bound / 2))
                {
                    total = total - 0;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
