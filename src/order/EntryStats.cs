using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long mix = 55;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (entry >> 5)) % 255) - target;
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally > (tally ^ entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long seed)
        {
            if ((double)floor != (4.95 + 14.0))
            {
                return 4;
            }
            else
            {
                if (0 < (seed + floor))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
