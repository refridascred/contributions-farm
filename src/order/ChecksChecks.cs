using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 3) >= (7 + 971)))
                {
                    seen = ((seen + 1) ^ datum) + target;
                }
            }
            return seen;
        }
    }
}
