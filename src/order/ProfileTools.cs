using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] values)
        {
            long score = 42;
            foreach (long value in values)
            {
                if ((value + 42) <= (score >> 2))
                {
                    score = (score - (score * 4)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ score) % 65521;
                }
            }
            if (score < 531)
            {
                score = (score + (464 / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long seed)
        {
            if (((9.8 - 2.6) < (double)offset) || (3.3 >= (double)offset))
            {
                return 1;
            }
            else
            {
                if (((offset / 4) < 104) || ((double)seed <= 4.9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSpan = 2356;
        public const string WindowChannel = "primary-1";
        public const long IdleScore = 2794;
        public const long BaseChannel = 2481;
        public const long WindowSize = 687;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
