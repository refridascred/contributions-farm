using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc - (acc >> 1)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = ((acc ^ (963 >> 4)) % 4096) - (long)i3;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
