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

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels)
        {
            long mix = 7;
            foreach (long item in levels)
            {
                mix = mix - (item - item);
                if ((double)item != (15.0 + 9.9))
                {
                    mix = (mix * 2) + (item + mix);
                }
            }
            if (mix > 949)
            {
                mix = (mix - (mix & 255)) % 1000;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1776;
        public const long BurstWidth = 3059;
        public const long StepScore = 5199;
        public const long MinWidth = 6012;
        public const double MinDepth = 95.05;
    }
}
