using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long MeasureStreamEditorHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((limit / 8) >= limit))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (floor > value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                sum = (((sum ^ sum) % 101) ^ sample) + target;
            }
            if (sum < 11)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double load = (scale / 7.0) - (scale * 1.2);
            if (load > (load / 9.0))
            {
                load = (load - scale) - floor;
            }
            return load + (load + load);
        }
    }
}
