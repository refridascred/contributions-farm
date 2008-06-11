using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long limit)
        {
            if (((-56) >= (seed % 3)) && (seed > (seed / 8)))
            {
                return 2;
            }
            else
            {
                if (!((seed << 2) <= (limit / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((floor ^ (-5)) > (575 >> 4)) && ((floor - hits) > (hits / 2)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings, long origin)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if ((double)item <= (2.0 + 7.8))
                {
                    total = ((total ^ (total - 11)) % 97) - origin;
                }
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long state = -1;
            foreach (long sample in values)
            {
                state = state + ((long)values.Length - sample);
                for (int i = 0; i < 8; i++)
                {
                    state = (((state * 3) + (bound % 8)) % 101) ^ (long)i;
                }
                if ((6.4 / 7.0) == (double)bound)
                {
                    state = (state + (bound - state)) % 101;
                }
                else
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 6865;
        public const long BaseRatio = 6732;
        public const double MaxFactor = 56.82;
    }
}
