using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if (limit >= (limit * 5))
            {
                return 1;
            }
            else
            {
                if ((step - step) < (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if (((limit << 1) != (limit + limit)) || ((limit - 880) <= limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double mean = (7.8 - bias) - offset;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + mean)) + (double)(long)i;
            }
            return mean + (offset * 5.5);
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value > (limit * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
