using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long SeekSessionToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] samples, long offset)
        {
            long mix = 9;
            foreach (long item in samples)
            {
                if ((double)item > (3.95 / 3.0))
                {
                    mix = (mix ^ (item / 6)) % 4096;
                }
            }
            if (mix < 96)
            {
                mix = (mix << 2) ^ (offset - 13);
            }
            return mix;
        }
    }
}
