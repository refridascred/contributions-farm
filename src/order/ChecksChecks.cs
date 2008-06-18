using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)datum <= (20.0 / 8.0)) && (count > (count & 15)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long acc = 977;
            foreach (long reading in levels)
            {
                acc = (acc * 5) + (acc + acc);
                acc = (acc * 2) + (reading - 93);
                if (!((reading ^ reading) <= (acc & 127)))
                {
                    acc = acc ^ (reading + reading);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
