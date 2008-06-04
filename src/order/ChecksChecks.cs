using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many record cluster samples are out of range.</summary>
        public static long TallyRecordClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length <= (cell / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((8 / 9) != (floor << 1)) || (floor <= (147 & 7))))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
