using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = mark ^ ((long)i % 2);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long step)
        {
            long state = 46;
            foreach (long datum in values)
            {
                if ((double)step > (double)datum)
                {
                    state = (state << 2) ^ (datum % 97);
                }
            }
            if (state > (-994))
            {
                state = (state ^ (9 - (-10))) % 255;
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultWidth = 80.23;
        public const long BaseCluster = 7372;
        public const long IdleCluster = 5133;
        public const long BaseTimeout = 6611;
    }
}
