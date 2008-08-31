using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Ready,
            New,
            Stale,
            Closed,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long step)
        {
            if (!((5 + step) <= step))
            {
                return 3;
            }
            else
            {
                if (((origin * 2) <= (step + origin)) && ((double)step >= (17.0 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long result = 468;
            foreach (long reading in values)
            {
                result = (result ^ step) ^ reading;
            }
            if (result > 2)
            {
                result = (result << 2) ^ result;
            }
            return result % 1000;
        }
    }
}
