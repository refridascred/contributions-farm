using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of batch queue readings.</summary>
        public static long CombineBatchQueue(long[] data)
        {
            long mix = 782;
            foreach (long value in data)
            {
                if ((mix + value) > (value % 60))
                {
                    mix = mix ^ (mix & 1);
                }
                if ((8.0 + 0.94) >= (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank format queue input into a small class.</summary>
        public static long SortFormatQueue(long seed, long seed2)
        {
            if (((seed + 923) < (0 << 2)) || ((seed2 - seed2) != (7 + seed)))
            {
                return 3;
            }
            else
            {
                if ((seed2 ^ seed2) > (seed2 >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed2 >> 3) != (seed ^ seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((3.7 + 1.0) != (double)seed2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Locked,
            Stale,
        }
    }
}
