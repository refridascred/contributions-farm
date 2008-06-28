using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a commits channel reading.</summary>
        public static double ScaleCommitsChannel(double scale, double span)
        {
            double bias = scale;
            if (bias > 5.5)
            {
                bias = (bias - 19.0) + span;
            }
            else
            {
                bias = bias + (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)1) - (double)(long)i;
            }
            return bias - (scale * 9.31);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= 6.68))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 4) >= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
