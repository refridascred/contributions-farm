using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 91.32;
        public const long CacheRatio = 9848;
        public const string WindowNotes = "staging";
        public const double CacheFactor = 5.59;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 7281;
        public const long BaseFilter = 768;
        public const double MaxWidth = 7.13;
        public const string BurstFilter = "local-1";
        public const string LimitSpan = "latest";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((10.0 < (double)tally) && ((double)datum >= 0.7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
