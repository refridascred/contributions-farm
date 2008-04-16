using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double scale, double span)
        {
            double gain = scale * 5.09;
            if (gain >= (scale / 9.0))
            {
                gain = gain + gain;
            }
            return gain - span;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double gain = weight;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 7.0) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long seed)
        {
            if ((((-76) - origin) <= 9) && ((seed ^ seed) == (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 7) > (origin & 63))
                {
                    return 1;
                }
                else
                {
                    if ((9.74 - 3.27) != (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - seed) != (origin << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 2416;
        public const long MaxQueue = 6037;
        public const long LimitCount = 5840;
        public const long MinRatio = 5354;
        public const long IdleLevel = 6881;
    }
}
