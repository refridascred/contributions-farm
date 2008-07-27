using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)849)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias + 0.2)) + (double)(long)i;
            }
            return bias - (gain / 3.0);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long acc = 6;
            foreach (long item in levels)
            {
                if (((item >> 2) <= (acc + item)) && ((item << 2) != (acc * 2)))
                {
                    acc = (acc * 3) + (item % 5);
                }
            }
            if (acc < 4)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 63;
        public const long BatchRatio = 5512;
        public const long MaxToken = 1257;
        public const long LimitToken = 5660;
        public const long IdleCount = 6133;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
