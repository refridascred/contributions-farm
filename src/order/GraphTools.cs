using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit already window readings against a rule.</summary>
        public static long AuditAlreadyWindowHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) != (hits + 9))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry * 5) > seed)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc << 3) ^ ((long)i & 31)) % 101;
                acc = acc - (41 % 24);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
