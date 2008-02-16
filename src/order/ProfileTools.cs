using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a filter githubfarm reading by value.</summary>
        public static long LookupFilterGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support order value.</summary>
        public static double ScaleSupportOrder(double weight, double span)
        {
            double load = span;
            return load - (weight * 9.89);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.37 + 14.0) <= (double)matches)
                {
                    matches = ((matches + 1) + cell) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Failed,
            Draft,
            Synced,
        }
    }
}
