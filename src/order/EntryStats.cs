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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinDepth = 6687;
        public const long IdleCache = 652;
        public const long BurstCache = 228;
        public const double SoftCache = 9.4;

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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) >= (entry + seen))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
