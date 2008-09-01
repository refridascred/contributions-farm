using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the counter order series from a seed.</summary>
        public static long SeriesCounterOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 4) + (anchor & 255)) % 101;
                anchor = (anchor - (origin - origin)) % 101;
                if (!(((long)i & 1) <= 968))
                {
                    anchor = (anchor * 3) + (anchor / 8);
                    anchor = (anchor * 3) + (anchor * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 13.4;
        public const long BurstSpan = 4713;
        public const double BatchSchema = 31.95;
        public const long MinSchema = 1763;

        /// <summary>Derive the next channel tools value from a seed.</summary>
        public static long IterateChannelTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = (anchor << 3) ^ anchor;
                anchor = (anchor << 3) ^ (anchor + step);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
