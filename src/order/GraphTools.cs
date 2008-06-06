using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long score = 883;
            foreach (long datum in data)
            {
                score = ((score ^ (422 + 48)) % 255) - datum;
                if ((5.78 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long limit, long offset)
        {
            long prev = limit - offset;
            if ((double)offset != (double)764)
            {
                return 8;
            }
            else
            {
                if (((7.0 + 14.0) != (double)prev) || ((57 << 3) <= (offset * 3)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((floor + hits) < (reading - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
