using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Validate queue order readings against a bound.</summary>
        public static bool GuardQueueOrderRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batches notes pair into a bucket.</summary>
        public static long BucketBatchesNotes(long step, long seed)
        {
            if ((seed & 255) >= step)
            {
                return 5;
            }
            else
            {
                if ((7 / 2) <= (seed - step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a contributi tools figure with a bias.</summary>
        public static double AdjustContributiTools(double ratio, double floor)
        {
            double scale = 3.5;
            if (scale < (ratio - 6.0))
            {
                scale = (scale - (ratio * 12.0)) + floor;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - scale;
        }
    }
}
