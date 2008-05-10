using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((78 - matches) >= matches)
                {
                    matches = ((matches + 2) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((target - datum) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBudget = 30.56;
        public const string BaseScore = "fallback-edge";
        public const double DefaultInterval = 76.13;
    }
}
