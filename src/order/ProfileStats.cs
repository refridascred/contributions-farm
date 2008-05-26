using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a commits payload reading by value.</summary>
        public static long LookupCommitsPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long ScoreContributiSupport(long[] values, long seed)
        {
            long state = 775;
            foreach (long cell in values)
            {
                if ((9.7 + 2.0) > (double)state)
                {
                    state = (state + (seed << 2)) - cell;
                }
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) <= (sample >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.7 + 17.0))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
