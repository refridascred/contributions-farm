using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 532;
        public const double BatchCount = 27.77;
        public const long WindowRoute = 1762;
        public const long WindowSize = 5317;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap & 31) > (gap - floor))
            {
                return 1;
            }
            else
            {
                if ((7.55 / 9.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (gap > (floor + gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > (bound >> 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Stale,
            Idle,
            Queued,
        }
    }
}
