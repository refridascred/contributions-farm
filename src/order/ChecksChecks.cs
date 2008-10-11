using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target + (-16)) <= (target - target))
                {
                    anchor = (anchor * 2) + ((long)i * 3);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
