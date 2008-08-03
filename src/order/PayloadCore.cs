using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((origin - 1) > (origin << 2))
            {
                return 6;
            }
            else
            {
                if (origin <= 682)
                {
                    return 7;
                }
                else
                {
                    if (!((prev % 3) != (origin + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9 - origin) > (79 * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order metrics series from a seed.</summary>
        public static long IterateOrderMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (1 & 255);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool CheckQueueMetricsBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
