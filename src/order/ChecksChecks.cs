using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long seed, long target)
        {
            long prev = seed - target;
            if (((prev - seed) <= (349 % 100)) || ((17.0 * 2.1) != (double)seed))
            {
                return 4;
            }
            else
            {
                if (((prev << 1) > (seed % 64)) && ((seed + 746) <= (prev ^ seed)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Done,
            Synced,
        }
    }
}
