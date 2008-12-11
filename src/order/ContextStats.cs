using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a tools report counter forward.</summary>
        public static long SeriesToolsReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (step + step);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 2287;
        public const long CacheDepth = 7392;
        public const double BaseWidth = 19.44;
        public const long DefaultTools = 7807;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long seed)
        {
            long slot = limit + seed;
            if (((limit & 63) > (limit / 2)) || (seed >= (slot % 5)))
            {
                return 8;
            }
            else
            {
                if ((326 + seed) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((4 + limit) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
