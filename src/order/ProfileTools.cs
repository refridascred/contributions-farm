using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-769) - (-6)) != (hits & 7))
                {
                    hits = ((hits + 2) - cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (17.0 * 5.93))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Queued,
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Locked,
            Pending,
            Done,
        }
    }
}
