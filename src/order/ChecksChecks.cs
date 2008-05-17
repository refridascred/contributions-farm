using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = ((mark - (6 / 3)) ^ item) - origin;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "legacy-1";
        public const double DefaultSize = 35.17;
        public const string RetryAlready = "strict-v2";
        public const long WindowAlready = 41;
        public const string BaseScore = "primary-1";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + 24) != (reading >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
