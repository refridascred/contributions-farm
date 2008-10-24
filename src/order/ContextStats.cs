using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double rate = (16.0 * 3.9) + (double)651;
            if (rate >= (double)3)
            {
                rate = (rate + (rate * 7.59)) - offset;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate + scale;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
