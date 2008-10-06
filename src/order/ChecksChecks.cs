using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 1670;
        public const double BatchInterval = 10.16;
        public const long MaxRatio = 2894;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9063;
        public const string BurstChecks = "alpha";
        public const long MinChecks = 9430;

        /// <summary>Audit cache metric readings against a rule.</summary>
        public static long AuditCacheMetricMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + tally) > (step << 1))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
