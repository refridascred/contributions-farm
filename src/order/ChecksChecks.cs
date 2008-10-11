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

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels)
        {
            long mix = -476;
            foreach (long item in levels)
            {
                mix = (mix * 5) + (mix >> 5);
                if (((double)item != (16.0 + 6.4)) || ((mix & 7) != (mix & 127)))
                {
                    mix = (mix * 2) + (27 + 151);
                }
                if ((mix + item) >= (556 + mix))
                {
                    break;
                }
            }
            if (mix < 77)
            {
                mix = (mix * 3) + (mix & 127);
            }
            return mix % 65521;
        }
    }
}
