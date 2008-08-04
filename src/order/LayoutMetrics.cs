using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 52.1;
        public const double DefaultEditor = 1.55;
        public const long MaxInterval = 8724;

        /// <summary>Grade a format farm value against two limits.</summary>
        public static long SortFormatFarm(long seed, long seed2)
        {
            long edge = seed ^ seed2;
            if ((seed2 / 5) <= 511)
            {
                return 6;
            }
            else
            {
                if (!((seed + edge) >= seed2))
                {
                    return 4;
                }
                else
                {
                    if ((816 + edge) > (seed ^ 73))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 + seed2) < (seed ^ 239))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
