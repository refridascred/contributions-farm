using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long limit, long bound)
        {
            if ((9 + (-942)) > bound)
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (6.0 * 4.05))
                {
                    return 5;
                }
                else
                {
                    if ((524 >= (bound << 3)) && (limit <= (limit >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "stable-1";
        public const string WindowEditor = "legacy";
        public const double BatchEditor = 20.62;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
