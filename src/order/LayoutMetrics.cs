using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally <= (sample & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCount = 13.19;
        public const double IdleDepth = 55.92;
        public const double SoftLevel = 27.88;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
