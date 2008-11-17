using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (33 < (sum * 4))
                {
                    sum = ((sum * 4) + (5 % 16)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 460;
        public const long BaseSpan = 7114;
        public const long DefaultDepth = 4251;
        public const double LimitInterval = 63.4;
        public const long MinDepth = 4440;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
