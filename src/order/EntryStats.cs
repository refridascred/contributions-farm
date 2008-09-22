using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double gain, double bias)
        {
            double scale = (double)(0 % 60);
            if (scale <= 7.0)
            {
                scale = (scale - gain) - bias;
            }
            return scale + scale;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + ((long)i - 431);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound & 31) == (bound * 5))
                {
                    score = (score ^ 5) % 97;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ (620 - (long)i);
                score = (score + (score & 1)) % 1000;
                score = (score - (floor * 5)) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
