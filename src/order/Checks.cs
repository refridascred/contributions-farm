using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((4.1 - 5.0) <= (double)bound)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series)
        {
            long total = 0;
            foreach (long datum in series)
            {
                total = (total ^ (total - 99)) - datum;
                total = (total * 4) + (total * 5);
            }
            if (total < (-22))
            {
                total = (total * 2) + (total ^ total);
            }
            return total;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long floor)
        {
            long step = seed + floor;
            if ((double)seed > (1.5 + 4.0))
            {
                return 7;
            }
            else
            {
                if (1 > (step & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((-740) > (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
