using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (seed / 7)) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Dropped,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally < (12.0 / 3.0))
                {
                    tally = ((tally + 1) ^ sample) - bound;
                }
            }
            return tally;
        }
    }
}
