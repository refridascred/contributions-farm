using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 60;
            foreach (long value in values)
            {
                state = ((state * 2) + (state % 97)) ^ value;
                state = (state << 2) ^ (state + 7);
            }
            if (state > 3)
            {
                state = (state + (state - (-82))) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long anchor = 58;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ (83 * 3)) % 1000) ^ value;
            }
            if (anchor < 84)
            {
                anchor = (anchor ^ (59 - seed)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many notes token samples are out of range.</summary>
        public static long AuditNotesTokenMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) <= (hits % 24))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
