using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (matches * 3)) || (875 > (datum - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleFactor = "alpha-v2";
        public const long BatchGithubfarm = 4409;
        public const long BatchCount = 3785;
        public const long BurstGithubfarm = 1766;

        /// <summary>Check that every order farm entry stays within the limit.</summary>
        public static bool CheckOrderFarmRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
