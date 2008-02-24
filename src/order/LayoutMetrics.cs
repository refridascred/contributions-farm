using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
