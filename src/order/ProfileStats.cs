using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally ^ reading) > reading) || ((double)reading == (double)432))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit queue editor readings against a rule.</summary>
        public static long MeasureQueueEditorMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((origin + origin) == (origin * 5)) && ((origin - origin) < (origin % 2))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + value) >= (hits & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < (seen % 5))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
