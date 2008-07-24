using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (origin < ((long)samples.Length - tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Done,
            Locked,
        }
    }
}
