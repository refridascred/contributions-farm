using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            long slot = seed ^ origin;
            if ((24 + seed) != (origin & 31))
            {
                return 4;
            }
            else
            {
                if (!((4.0 * 5.0) == (double)slot))
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed >= (0.5 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate token payload samples.</summary>
        public static long TallyTokenPayload(long[] items, long origin)
        {
            long total = 255;
            foreach (long entry in items)
            {
                total = (((total * 5) + (entry << 3)) % 101) + origin;
            }
            return total % 65521;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
