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

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values)
        {
            long score = 540;
            foreach (long cell in values)
            {
                score = (score << 3) ^ (score - cell);
            }
            return score % 1000;
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
