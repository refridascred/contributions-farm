using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile farm samples.</summary>
        public static long DigestProfileFarm(long[] readings, long target)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if (!((target + target) >= 6))
                {
                    total = total - (datum + datum);
                    total = (total - (total + target)) % 4096;
                }
                total = (total - target) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (ratio - drift))
            {
                drift = (drift - (double)4) - floor;
            }
            return drift - 2.5;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 6062;
        public const string WindowQueue = "standard-1";
        public const double CacheInterval = 95.03;
        public const string HardQueue = "latest";
    }
}
