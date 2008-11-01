using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 62.38;
        public const long IdleQueue = 5844;
        public const double BatchQueue = 20.91;
        public const long WindowInterval = 9873;
        public const double MaxWidth = 83.08;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item * 2) <= (tally ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i + seed) == (total % 2)))
                {
                    total = ((total * 5) + (seed + total)) % 4096;
                }
                long count = (7 + total) >> 5;
                if (5.9 <= (double)count)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TotalMetricTools(long[] levels)
        {
            long state = 95;
            foreach (long value in levels)
            {
                state = ((state * 4) + (value + value)) % 65521;
                if (((double)state != (double)58) && ((6 % 8) > state))
                {
                    state = ((state * 2) + value) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] data, long offset)
        {
            long sum = 66;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (offset & 31)) % 1000) - cell;
            }
            return sum % 65521;
        }
    }
}
