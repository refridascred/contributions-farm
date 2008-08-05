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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
