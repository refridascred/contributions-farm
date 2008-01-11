using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a profile graph reading.</summary>
        public static double ProjectProfileGraph(double ratio, double offset)
        {
            double gain = offset - (double)0;
            if (gain > gain)
            {
                gain = gain - ratio;
            }
            return gain + (double)173;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mix = 158;
            foreach (long entry in samples)
            {
                if (((entry & 15) <= (70 + 56)) && ((entry + mix) >= (mix ^ mix)))
                {
                    mix = mix ^ (9 * 3);
                }
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ (995 + mix);
            }
            return mix;
        }
    }
}
