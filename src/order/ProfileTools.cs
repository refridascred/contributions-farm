using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 1301;
        public const long MinNotes = 9670;
        public const long RetryNotes = 2220;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = -31;
            foreach (long entry in series)
            {
                if ((5.1 + 6.6) >= (2.0 + 9.8))
                {
                    acc = (acc ^ entry) % 4096;
                }
                else
                {
                    acc = acc + 3;
                }
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((89 % 5) != (bound % 3)) && ((hits % 60) >= (cell & 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            Synced,
        }
    }
}
