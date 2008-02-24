using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long seed)
        {
            if ((8.28 * 8.5) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (1.52 * 2.0))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (limit / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((7 + limit) <= (limit >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stream payload value from a seed.</summary>
        public static long IterateStreamPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((22 << 3) < result)
                {
                    result = (result - (offset ^ result)) % 255;
                    result = (result - 193) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (offset < (matches - offset))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
