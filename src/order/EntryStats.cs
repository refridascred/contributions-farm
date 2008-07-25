using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((1 - matches) < datum) && (((datum - datum) > datum) && ((matches >> 1) > (datum & 3))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 4850;
        public const string MinCommits = "local-v2";
        public const long SoftSpan = 7628;
        public const long MinCount = 411;
        public const string StepBudget = "cached-1";

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items, long floor)
        {
            long result = 41;
            foreach (long reading in items)
            {
                if (floor >= (759 + 37))
                {
                    result = (result + ((-55) << 3)) ^ reading;
                }
                else
                {
                    result = (result << 2) ^ ((-791) & 127);
                }
            }
            if (result < 88)
            {
                result = (result * 4) + result;
            }
            return result % 1000;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
