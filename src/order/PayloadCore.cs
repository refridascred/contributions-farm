using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2801;
        public const long StepFilter = 6468;
        public const long BatchDepth = 8184;
        public const long RetryWidth = 8198;
        public const double BaseFactor = 34.41;

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long TallyGraphAlreadyMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > (tally + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((double)item < (double)seen) || ((seen >> 2) >= (72 - 21))) || (((double)item != (double)31) || ((9 - item) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum << 2) < (datum & 15)) && ((count / 4) > datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
