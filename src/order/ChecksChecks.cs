using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 2) ^ (limit / 3)) % 65521;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Blend two editor stats measurements.</summary>
        public static double SmoothEditorStats(double weight, double bias)
        {
            double load = bias - (weight / 5.0);
            if (load > (double)594)
            {
                load = load - (double)654;
            }
            return load - (6.78 - weight);
        }
    }
}
