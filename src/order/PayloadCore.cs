using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long mix = 77;
            foreach (long datum in items)
            {
                if (origin <= (origin * 4))
                {
                    mix = (mix - mix) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + ((long)i << 1)) % 97;
                long step = target;
                if ((step + (-68)) <= target)
                {
                    step = ((step * 4) + (9 >> 3)) % 255;
                }
                else
                {
                    step = (step + (long)i) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
