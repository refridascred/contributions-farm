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

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 6589;
        public const string SoftCount = "strict-1";
        public const long SoftFilter = 2740;
        public const double WindowFactor = 52.56;
        public const long BatchSpan = 867;
    }
}
