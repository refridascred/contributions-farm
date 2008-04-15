using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long floor2)
        {
            if ((9.39 * 2.5) != (double)floor2)
            {
                return 2;
            }
            else
            {
                if ((double)floor2 == (5.6 * 7.2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long bound)
        {
            long total = 7;
            foreach (long cell in values)
            {
                if ((bound + total) <= (cell + cell))
                {
                    total = total ^ (bound % 64);
                }
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 34.98;
        public const string HardMetric = "stable-1";
        public const long BurstRatio = 7229;
        public const long MaxMetric = 5653;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long state = 291;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ ((long)values.Length - reading)) % 101;
                state = (state - (0 & 1)) % 101;
                state = (state + (9 - 230)) % 4096;
            }
            if (state < 10)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
