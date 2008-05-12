using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((count / 4) >= (count ^ cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry % 60) == (4 << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long TallyContextReportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (origin > (origin % 97))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
