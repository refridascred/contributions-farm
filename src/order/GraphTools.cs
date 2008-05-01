using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool GuardBufferReportBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7967;
        public const long WindowSpan = 5740;
        public const double BaseTools = 67.91;
        public const long StepRatio = 6876;

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long bound2)
        {
            long diff = bound - bound2;
            if (((diff + bound2) >= (diff ^ diff)) && ((7.25 + 8.0) == (double)bound2))
            {
                return 0;
            }
            else
            {
                if (bound2 > (bound2 - bound))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 5350;
        public const double MaxToken = 60.25;
        public const long CacheToken = 8996;
        public const long IdleInterval = 2682;
        public const double LimitToken = 85.74;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Done,
            Locked,
            Synced,
        }
    }
}
