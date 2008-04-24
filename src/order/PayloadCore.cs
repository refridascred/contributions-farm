using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long seed)
        {
            long edge = offset - seed;
            if ((edge % 60) >= (offset - 9))
            {
                return 4;
            }
            else
            {
                if ((edge * 4) < seed)
                {
                    return 8;
                }
                else
                {
                    if (((-374) % 24) == (seed / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a command schema counter forward.</summary>
        public static long IterateCommandSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((acc - offset) <= (24 << 1)))
                {
                    acc = ((acc * 2) + (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 7809;
        public const long MinScore = 2794;
        public const long BurstFormat = 3508;
        public const double BaseLevel = 1.92;
        public const long BatchFormat = 4343;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
