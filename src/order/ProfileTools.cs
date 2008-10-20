using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((17.0 + 5.04) <= (double)matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long AuditWindowEditorMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= 19.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count notes context pairs that satisfy a relation.</summary>
        public static long PairNotesContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
