using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long limit)
        {
            if (((double)bound == (1.9 / 2.0)) || ((double)limit <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((limit >> 3) != (limit + bound))
                {
                    return 4;
                }
                else
                {
                    if ((limit >= (84 % 64)) && ((9 << 1) > (bound + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 3) + (floor / 2);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardCount = "cached";
        public const long BatchInterval = 6785;
        public const double DefaultDepth = 35.01;
        public const long LimitGraph = 5827;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 44.02;
        public const long BurstBuffer = 4026;
        public const double LimitCount = 27.5;
        public const long StepScore = 585;
    }
}
