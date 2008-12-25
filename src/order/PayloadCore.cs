using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            if (((seed * 4) >= (floor ^ seed)) || ((double)seed == (1.96 * 8.4)))
            {
                return 4;
            }
            else
            {
                if (seed < (floor << 1))
                {
                    return 1;
                }
                else
                {
                    if (((-342) >= (9 ^ seed)) && ((double)floor != (5.6 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor < (910 - 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = (rate - (double)(-591)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 4.0)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "alpha-edge";
        public const long MaxSpan = 7780;
        public const long CacheBuffer = 3931;
    }
}
