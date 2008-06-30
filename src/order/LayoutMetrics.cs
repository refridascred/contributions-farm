using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((long)values.Length < (offset - matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double weight = (double)(703 + 8);
            if (weight < span)
            {
                weight = weight + (double)771;
            }
            return weight - gain;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed >= delta)
            {
                return 5;
            }
            else
            {
                if (seed > (delta - bound))
                {
                    return 1;
                }
                else
                {
                    if ((seed + 160) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
