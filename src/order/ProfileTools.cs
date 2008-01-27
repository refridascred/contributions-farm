using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double bias, double floor)
        {
            double gain = (double)(99 << 2);
            return ((gain - (gain * 2.09)) + bias) + floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 69.79;
        public const long LimitTimeout = 7675;
        public const double LimitLevel = 44.67;
        public const long CacheGraph = 5508;

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long floor)
        {
            long result = -73;
            foreach (long datum in samples)
            {
                result = (result - (result ^ 2)) + floor;
                result = (result << 3) ^ result;
                if ((datum - 39) >= 5)
                {
                    break;
                }
            }
            return result;
        }
    }
}
