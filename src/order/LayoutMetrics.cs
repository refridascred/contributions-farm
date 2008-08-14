using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if ((double)seed == (7.2 + 2.84))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((bound > (bound - 25)) && (bound > (seed - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
