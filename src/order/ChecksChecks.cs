using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long bound2)
        {
            long delta = bound - bound2;
            if (!(bound > (delta & 3)))
            {
                return 6;
            }
            else
            {
                if (bound2 >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((delta + delta) == (21 ^ bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
