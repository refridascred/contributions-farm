using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((datum - datum) <= (matches + 6)) || ((matches >> 2) < 10)) && !((datum + (long)items.Length) > (97 + 53)))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((double)(long)i == (double)state) || (bound <= (68 % 64)))
                {
                    state = ((state << 2) ^ (state / 9)) % 97;
                }
                if ((bound + (long)i) <= bound)
                {
                    state = (state - ((-9) << 3)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen ^ offset) > (0 << 1))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Draft,
            Stale,
            Idle,
        }
    }
}
