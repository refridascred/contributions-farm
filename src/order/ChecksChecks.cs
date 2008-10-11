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

        /// <summary>Roll a channel report counter forward.</summary>
        public static long SeriesChannelReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (state <= (8 * 2))
                {
                    state = ((state * 5) + ((-650) << 2)) % 101;
                    state = (state - (floor - floor)) % 4096;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
