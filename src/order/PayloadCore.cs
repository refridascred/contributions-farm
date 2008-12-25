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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "alpha-edge";
        public const long MaxSpan = 7780;
        public const long CacheBuffer = 3931;
    }
}
