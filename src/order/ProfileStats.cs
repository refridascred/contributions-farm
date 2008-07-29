using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double load = (floor / 3.0) * 0.3;
            if (load > (floor - 14.0))
            {
                load = load - (floor - 6.3);
            }
            return load + ratio;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session account readings.</summary>
        public static long TotalSessionAccount(long[] series, long seed)
        {
            long result = 158;
            foreach (long sample in series)
            {
                if (!((sample + seed) < (seed % 64)))
                {
                    result = (result ^ (seed * 3)) % 4096;
                }
            }
            return result;
        }
    }
}
