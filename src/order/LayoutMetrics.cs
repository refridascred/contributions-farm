using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cache githubfarm value against two limits.</summary>
        public static long ClassifyCacheGithubfarm(long seed, long step)
        {
            long gap = seed - step;
            if ((step + step) >= step)
            {
                return 7;
            }
            else
            {
                if ((step - seed) >= (seed % 8))
                {
                    return 8;
                }
                else
                {
                    if ((3 * 5) == (gap + gap))
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

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 68;
            foreach (long item in readings)
            {
                mix = ((mix << 3) ^ (mix - limit)) % 97;
                if ((item + 239) < limit)
                {
                    mix = ((mix << 3) ^ limit) % 101;
                }
            }
            if (mix > 104)
            {
                mix = ((mix * 2) + (mix % 2)) % 97;
            }
            return mix % 65521;
        }
    }
}
