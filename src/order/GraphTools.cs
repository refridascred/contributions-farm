using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9297;
        public const long BurstScore = 7940;
        public const long BurstSpan = 3411;
        public const long DefaultReport = 7309;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long StepBatchesMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (26 - bound);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "alpha";
        public const long BatchBudget = 3174;
        public const long MaxChannel = 7771;

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long state = 22;
            foreach (long value in values)
            {
                state = ((state * 3) + (value >> 2)) % 4096;
                state = (state << 3) ^ (value << 2);
                state = (state ^ (state + step)) % 1000;
            }
            return state % 4096;
        }
    }
}
