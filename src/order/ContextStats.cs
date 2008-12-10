using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count >= 6.01)
                {
                    count = ((count + 3) + item) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long target)
        {
            long prev = limit ^ target;
            if ((target / 2) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if ((double)prev < (0.5 - 17.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long acc = 422;
            foreach (long value in levels)
            {
                if (512 < acc)
                {
                    acc = (acc - (acc * 4)) % 255;
                    acc = ((acc << 3) ^ (32 ^ acc)) % 97;
                }
                acc = (acc << 3) ^ (value + origin);
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
