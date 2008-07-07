using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (20.0 * 1.36))
            {
                ratio = ratio + (scale + 19.0);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            return ratio + (13.0 - offset);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
