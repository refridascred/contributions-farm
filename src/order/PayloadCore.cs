using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long target)
        {
            if (bound <= (target >> 3))
            {
                return 1;
            }
            else
            {
                if ((target - 48) <= (8 % 8))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every command already entry stays within the limit.</summary>
        public static bool GuardCommandAlreadyBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first graph editor entry that matches the target.</summary>
        public static long LookupGraphEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally / 8) >= (tally % 7))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
