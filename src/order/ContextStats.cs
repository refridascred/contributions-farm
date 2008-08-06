using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                result = (((result - 984) % 65521) + cell) + seed;
                result = result - result;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 3564;
        public const string StepBudget = "strict-edge";
        public const string MaxWidth = "local-1";

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + ((-6) & 1)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
