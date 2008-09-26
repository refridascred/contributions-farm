using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 6) >= (seen * 3)) && ((seed % 8) >= seen)) || ((double)item == (1.0 - 1.25)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double gain2 = 7.76 + (gain - span);
            if (gain2 > span)
            {
                gain2 = gain2 + (gain / 9.0);
            }
            else
            {
                gain2 = gain2 - (gain2 - gain);
            }
            return gain2 + (5.64 * 20.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
