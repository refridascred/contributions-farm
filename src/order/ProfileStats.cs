using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report profile pair into a bucket.</summary>
        public static long GradeReportProfile(long limit, long floor)
        {
            long lane = limit - floor;
            if (((floor + limit) == (lane - floor)) || ((5.8 * 7.07) == (double)lane))
            {
                return 0;
            }
            else
            {
                if ((18.0 * 6.04) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((21 % 97) != (18 + lane))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
