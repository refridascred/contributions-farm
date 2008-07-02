using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route payload value.</summary>
        public static double SmoothRoutePayload(double scale, double span)
        {
            double gain = span;
            if (gain < (span + scale))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (span - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Grade a format profile value against two limits.</summary>
        public static long BucketFormatProfile(long step, long bound)
        {
            if ((step + step) > (73 + step))
            {
                return 6;
            }
            else
            {
                if (step < (bound + step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length < (entry + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
