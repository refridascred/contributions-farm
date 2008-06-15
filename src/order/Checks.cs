using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = (mean - (double)24) + bias;
            }
            else
            {
                mean = mean + bias2;
            }
            return mean - (double)(-8);
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Paused,
            New,
            Draft,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((14.0 * 19.0) < (double)seed) && ((double)floor <= (double)42))
            {
                return 7;
            }
            else
            {
                if ((floor - 2) == (floor - cur))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(datum < (datum / 2)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
