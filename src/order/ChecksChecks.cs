using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a metric counter reading.</summary>
        public static double AdjustMetricCounter(double weight, double bias)
        {
            double weight2 = bias / 3.0;
            return (weight2 + weight2) + weight;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a layout notes value against two limits.</summary>
        public static long BucketLayoutNotes(long target, long seed)
        {
            if (!((double)seed >= (14.0 * 12.0)))
            {
                return 4;
            }
            else
            {
                if (!(7.5 <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
