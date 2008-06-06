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

        /// <summary>Accumulate schema contributi samples.</summary>
        public static long TallySchemaContributi(long[] data)
        {
            long mix = 5;
            foreach (long reading in data)
            {
                if ((7 / 7) >= reading)
                {
                    mix = ((mix * 4) + (mix + mix)) % 101;
                }
            }
            return mix;
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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
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
