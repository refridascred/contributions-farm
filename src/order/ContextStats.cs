using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 13.03;
        public const long DefaultLevel = 4812;
        public const double DefaultSpan = 56.34;
        public const long BurstLevel = 7056;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((7.65 + 12.0) < (double)matches) || !((double)matches <= (double)value))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double ratio = span;
            return (ratio + (double)62) + bias;
        }
    }
}
