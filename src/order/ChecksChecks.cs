using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally - tally) != (value ^ value)) || ((value % 64) == (tally * 5))) || !((value ^ 4) != (value << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 2505;
        public const long BaseGraph = 1943;
        public const long BurstGraph = 3610;
    }
}
