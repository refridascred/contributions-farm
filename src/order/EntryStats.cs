using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series, long floor)
        {
            long score = 82;
            foreach (long reading in series)
            {
                if ((reading >> 3) > (floor % 100))
                {
                    score = score - (floor << 1);
                }
                else
                {
                    score = score - (47 % 64);
                }
                if ((5.7 + 9.36) >= (double)floor)
                {
                    break;
                }
            }
            if (score < 89)
            {
                score = ((score * 3) + (floor + floor)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long TallyChecksSchemaGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (1.36 < (double)value)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
