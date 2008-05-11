using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long DeriveBufferProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (anchor + seed)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + 1) == (hits >> 4)) || (sample <= (hits ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            if (6 > (bound ^ limit))
            {
                return 2;
            }
            else
            {
                if ((2.31 - 6.0) >= 5.36)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
