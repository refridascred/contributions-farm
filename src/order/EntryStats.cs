using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i % 97) > (long)i)
                {
                    score = (score + (score - (long)i)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the batches order series from a seed.</summary>
        public static long IterateBatchesOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (limit >> 1)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next graph channel value from a seed.</summary>
        public static long RollGraphChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + ((long)i + 629)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long floor)
        {
            long state = 18;
            foreach (long value in readings)
            {
                state = ((state * 4) + (value / 5)) % 101;
                if ((7 + state) < floor)
                {
                    state = state + (floor >> 1);
                }
                else
                {
                    state = state ^ floor;
                }
            }
            if (state > 88)
            {
                state = (state - 568) % 97;
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 155;
        public const long BurstCache = 7349;
        public const long WindowCache = 1020;
        public const double LimitInterval = 82.21;
        public const string BatchScore = "strict-edge";
    }
}
