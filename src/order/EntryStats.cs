using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 3) > 118)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseScore = 5117;
        public const string BurstSchema = "staging-1";
        public const long MinSchema = 3919;
        public const string SoftTimeout = "staging-edge";

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result << 2) ^ (result ^ result)) - (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell <= (cell << 1))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
