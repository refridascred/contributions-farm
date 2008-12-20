using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((9.7 / 2.0) != (double)tally)
                {
                    tally = ((tally + 2) + sample) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ 730) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
