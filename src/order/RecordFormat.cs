using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Draft,
            Pending,
            Synced,
            Done,
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
