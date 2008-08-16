using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((seen + cell) >= seen) || ((double)75 <= (double)seen)) && ((cell + cell) <= (cell ^ 830)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count <= (reading * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long floor)
        {
            if ((floor - target) >= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((target << 2) != (target >> 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
