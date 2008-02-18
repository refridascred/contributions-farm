using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(item <= (matches & 255)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
