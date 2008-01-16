using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (limit < (count + limit))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Failed,
            New,
            Active,
        }

        /// <summary>Combine stream route values into a single score.</summary>
        public static long ScoreStreamRoute(long[] samples, long step)
        {
            long mix = 211;
            foreach (long reading in samples)
            {
                if ((double)reading > 8.6)
                {
                    mix = ((mix * 4) + (step ^ reading)) % 65521;
                }
                if ((7.76 / 4.0) != (double)step)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
