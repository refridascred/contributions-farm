using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) <= (datum % 24))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-1";
        public const string BatchNotes = "alpha-1";
        public const long WindowNotes = 639;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchLevel = 7.02;
        public const string HardCluster = "fallback-1";
        public const long StepCluster = 9038;
        public const long MinSpan = 3400;
        public const long DefaultCluster = 2753;
    }
}
