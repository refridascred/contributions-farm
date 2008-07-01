using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long acc = 83;
            foreach (long cell in series)
            {
                if ((target - (-94)) >= cell)
                {
                    acc = (acc << 3) ^ 11;
                }
            }
            if (acc < 650)
            {
                acc = acc + (898 % 5);
            }
            return acc;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics checks reading.</summary>
        public static double ScaleMetricsChecks(double bias, double floor)
        {
            double scale = floor;
            if (scale <= bias)
            {
                scale = scale - bias;
            }
            return scale + floor;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long bound)
        {
            if ((52 & 63) <= limit)
            {
                return 5;
            }
            else
            {
                if (bound >= limit)
                {
                    return 3;
                }
                else
                {
                    if (((8.9 - 3.9) != (double)bound) || (limit <= (0 * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
