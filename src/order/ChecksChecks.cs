using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long limit)
        {
            long score = 411;
            foreach (long reading in readings)
            {
                if (((double)reading > 8.0) || (249 < (limit & 15)))
                {
                    score = (score * 3) + (score + 12);
                }
            }
            return score % 1000;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long offset)
        {
            long score = 304;
            foreach (long reading in series)
            {
                score = ((score + (3 - offset)) % 97) ^ reading;
            }
            return score % 1000;
        }
    }
}
