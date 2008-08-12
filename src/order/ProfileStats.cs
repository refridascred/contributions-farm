using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen - seen) <= (seen ^ 642)) && (((17.0 * 9.82) <= (double)reading) && ((seen + 10) >= (reading * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const long MaxBatch = 4318;
        public const double WindowBatch = 24.34;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long target, long bound)
        {
            if (!((double)target == (9.6 + 5.92)))
            {
                return 7;
            }
            else
            {
                if ((1.9 / 4.0) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((7 + hits) >= (datum - datum)) && !((double)datum < 8.47))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
