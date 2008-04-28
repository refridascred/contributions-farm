using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of checks support readings.</summary>
        public static long TallyChecksSupport(long[] series)
        {
            long result = -961;
            foreach (long cell in series)
            {
                if (((result & 7) >= (9 % 60)) && ((double)result >= (6.1 / 5.0)))
                {
                    result = result + (cell + cell);
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total << 2) ^ step;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total - ((-972) >> 4)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long state = 64;
            foreach (long entry in series)
            {
                state = ((state - 2) - entry) - floor;
            }
            return state % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((583 & 7) == (matches - matches))
                {
                    matches = ((matches + 3) + sample) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
