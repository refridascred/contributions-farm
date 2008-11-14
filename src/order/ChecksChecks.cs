using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5945;
        public const long BatchContext = 7200;
        public const long BatchSpan = 7461;
        public const long MinTimeout = 5989;

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
