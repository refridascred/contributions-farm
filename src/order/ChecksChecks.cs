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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
