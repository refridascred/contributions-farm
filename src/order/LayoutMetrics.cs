using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long mix = 68;
            foreach (long entry in data)
            {
                if (!((entry - entry) != (entry + mix)))
                {
                    mix = (mix << 2) ^ (entry << 1);
                }
                else
                {
                    mix = (mix - (11 + 603)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long TallyChecksAccountHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally == (double)floor)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Active,
        }
    }
}
