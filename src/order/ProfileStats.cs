using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double span)
        {
            double ratio = span;
            return ratio - (weight - weight);
        }

        /// <summary>Check that every layout order entry stays within the limit.</summary>
        public static bool VerifyLayoutOrderBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((17.0 / 8.0) <= (double)seen) || ((double)seen >= 7.7)) || ((double)seen < (19.0 - 3.67)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits > (32 & 3)) || ((hits + datum) <= datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
