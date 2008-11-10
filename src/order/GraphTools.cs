using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Validate report buffer readings against a bound.</summary>
        public static bool CheckReportBufferRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (reading - seen)) || ((44 & 3) <= (limit + 103)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen < (datum << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool CheckRoutePayloadLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
