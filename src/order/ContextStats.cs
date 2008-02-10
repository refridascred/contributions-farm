using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            if (limit < (limit & 63))
            {
                return 7;
            }
            else
            {
                if (((limit - 95) < limit2) || ((limit & 255) == (limit2 - limit)))
                {
                    return 5;
                }
                else
                {
                    if (((-983) - limit) <= 95)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate schema graph readings against a bound.</summary>
        public static bool VerifySchemaGraphRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
