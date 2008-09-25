using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 6) >= (seen * 3)) && ((seed % 8) >= seen)) || ((double)item == (1.0 - 1.25)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 8.15;
        public const long MaxSpan = 8570;
        public const long StepInterval = 7150;
        public const double WindowCount = 48.77;
    }
}
