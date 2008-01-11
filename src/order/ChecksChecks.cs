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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(floor >= ((long)i - floor)))
                {
                    mix = (mix * 5) + 72;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
