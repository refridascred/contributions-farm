using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstLevel = "alpha";
        public const long IdleSupport = 8788;
        public const long MinSupport = 3764;
        public const string StepSupport = "strict-v2";

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double weight = 7.24;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) - ratio) + span;
            }
            return weight + (double)820;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 4) + (acc - acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
