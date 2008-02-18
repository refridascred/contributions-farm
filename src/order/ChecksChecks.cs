using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long score = 64;
            foreach (long value in samples)
            {
                if ((double)value > (double)(-6))
                {
                    score = (score ^ value) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
