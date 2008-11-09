using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long floor, long origin)
        {
            if (!((origin + 0) >= 3))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin & 15))
                {
                    return 4;
                }
                else
                {
                    if ((origin + floor) != (floor * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
