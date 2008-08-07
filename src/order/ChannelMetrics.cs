using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a tools profile value against two limits.</summary>
        public static long SortToolsProfile(long origin, long seed)
        {
            long span = origin - seed;
            if ((seed - seed) < (origin + seed))
            {
                return 0;
            }
            else
            {
                if (!((double)span > (1.78 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    if (((-3) * 2) != (origin >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)span < (3.21 + 2.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen <= 5.8)
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
