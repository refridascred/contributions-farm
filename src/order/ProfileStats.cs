using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long limit)
        {
            long edge = target ^ limit;
            if ((76 + edge) == (limit ^ target))
            {
                return 3;
            }
            else
            {
                if ((target << 2) >= (target + limit))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long step)
        {
            if ((0.9 / 5.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((8.91 * 5.38) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((8.14 / 8.0) != (double)origin)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
