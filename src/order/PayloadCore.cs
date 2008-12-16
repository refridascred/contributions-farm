using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 976;
            foreach (long entry in series)
            {
                if ((entry << 1) < (entry & 255))
                {
                    sum = ((sum * 2) + (716 * 4)) % 101;
                }
                if ((sum >> 1) < sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell > ((long)series.Length ^ 4)) && ((bound + matches) >= matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long floor)
        {
            long state = 590;
            foreach (long cell in readings)
            {
                if (!((state % 3) == (cell >> 2)))
                {
                    state = ((state * 5) + state) % 4096;
                }
                else
                {
                    state = state ^ (floor + floor);
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (state / 9);
            }
            return state % 97;
        }
    }
}
