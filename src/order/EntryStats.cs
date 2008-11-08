using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every tools githubfarm entry stays within the limit.</summary>
        public static bool GuardToolsGithubfarmBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 5678;
        public const double HardReport = 13.2;
        public const string IdleRatio = "fallback";

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double drift = (double)9;
            if (drift <= 4.1)
            {
                drift = drift + 0.4;
            }
            else
            {
                drift = drift + (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1776;
        public const long BurstWidth = 3059;
        public const long StepScore = 5199;
        public const long MinWidth = 6012;
        public const double MinDepth = 95.05;
    }
}
