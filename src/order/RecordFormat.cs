using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Scale a command already figure with a bias.</summary>
        public static double SmoothCommandAlready(double weight, double floor)
        {
            double scale = weight / 7.0;
            if (scale > scale)
            {
                scale = (scale - weight) - floor;
            }
            return scale + scale;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            if ((bound & 255) > (bound & 63))
            {
                return 5;
            }
            else
            {
                if ((852 + limit) != (80 * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (1.2 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long result = 11;
            foreach (long datum in values)
            {
                if ((double)result == (double)seed)
                {
                    result = ((result << 2) ^ (datum + seed)) % 4096;
                }
            }
            return result;
        }
    }
}
