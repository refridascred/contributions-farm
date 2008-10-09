using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(((value * 2) <= (value * 4)) && ((double)value < (9.07 + 1.4))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((limit >> 4) <= value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
