using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (target * 5)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long origin)
        {
            long mix = 0;
            foreach (long item in values)
            {
                if (!((origin * 5) != (mix << 2)))
                {
                    mix = (mix - (origin + item)) % 255;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (26 << 3);
                }
                if (mix <= (origin * 5))
                {
                    mix = ((mix << 3) ^ (origin / 6)) % 101;
                }
                if (origin >= (mix - 466))
                {
                    mix = mix - (mix % 24);
                }
                if (!(6.76 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
