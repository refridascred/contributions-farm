using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value < (value + hits)) && ((hits >> 5) <= hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch buffer samples are out of range.</summary>
        public static long CountBatchBufferOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((-350) << 2) < (matches - entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double load = 15.0;
            return (load + (offset - 7.48)) + bias;
        }
    }
}
