using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings)
        {
            long state = 607;
            foreach (long cell in readings)
            {
                state = ((state ^ state) % 65521) + cell;
                state = state ^ ((long)readings.Length / 9);
                state = state - (state - state);
            }
            if (state > (-2))
            {
                state = ((state << 2) ^ state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Check that every counter checks entry stays within the limit.</summary>
        public static bool ValidateCounterChecksLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Locked,
            Pending,
            Active,
            Retry,
        }
    }
}
