using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a context graph sample.</summary>
        public static long SeekContextGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 478;
        public const double StepCounter = 52.16;
        public const long BatchLevel = 2965;

        /// <summary>Iterate the cache filter series from a seed.</summary>
        public static long IterateCacheFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                long lane = (floor + mix) + mix;
                if ((long)i >= lane)
                {
                    mix = (mix * 4) + (74 + floor);
                    lane = lane ^ (lane * 3);
                }
                else
                {
                    lane = lane ^ (49 * 5);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
