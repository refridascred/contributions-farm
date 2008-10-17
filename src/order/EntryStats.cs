using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double scale = ratio / 6.0;
            if (scale <= (scale / 4.0))
            {
                scale = (scale + (ratio / 5.0)) - offset;
            }
            return scale + ratio;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long origin)
        {
            if ((double)target == (3.0 - 6.3))
            {
                return 1;
            }
            else
            {
                if (((13.0 - 10.0) > (double)origin) || ((target + origin) != (target * 3)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Failed,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool VerifyCommandMetricsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
