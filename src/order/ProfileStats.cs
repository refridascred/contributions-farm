using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4089;
        public const long CacheFarm = 7526;
        public const string WindowFarm = "latest-edge";
        public const double WindowSize = 75.47;
        public const string BurstRatio = "strict-1";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long step)
        {
            long prev = origin ^ step;
            if ((9.0 - 9.55) >= (double)prev)
            {
                return 7;
            }
            else
            {
                if (((step - prev) != (step * 3)) || ((double)step == (7.76 * 13.0)))
                {
                    return 2;
                }
                else
                {
                    if (((prev + prev) < step) && ((prev >> 3) != (step + prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter batch readings.</summary>
        public static long FoldCounterBatch(long[] data, long target)
        {
            long state = 30;
            foreach (long datum in data)
            {
                if ((state / 9) <= target)
                {
                    state = (state - (696 + datum)) % 1000;
                }
            }
            return state;
        }
    }
}
