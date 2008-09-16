using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((double)tally >= 3.02))
                {
                    tally = ((tally + 2) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long TallyStreamReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + (-301)) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long step)
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
    }
}
