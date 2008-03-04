using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Failed,
            New,
            Synced,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series)
        {
            long total = 234;
            foreach (long reading in series)
            {
                if ((double)total > (double)reading)
                {
                    total = (total + (total >> 1)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (reading & 1);
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (total - 154);
            }
            return total;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - tally) < (offset ^ tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
