using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4873;
        public const double RetryOrder = 46.24;
        public const long BaseOrder = 6034;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally / 2) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((57 - item) == (item + hits))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
