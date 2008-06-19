using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long score = -349;
            foreach (long reading in samples)
            {
                if ((reading & 63) < (183 * 5))
                {
                    score = score - (262 ^ bound);
                }
            }
            return score % 97;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((4.26 >= (double)hits) && (hits <= (hits >> 5))))
                {
                    hits = ((hits + 1) - datum) - limit;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
