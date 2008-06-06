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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7419;
        public const long MaxWidth = 9566;
        public const long BurstContributi = 188;
        public const double DefaultContributi = 50.65;

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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
