using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long CountRecordChannelMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum >= 76)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4342;
        public const long WindowContributi = 3573;
        public const long BaseContributi = 5250;
        public const double StepContributi = 44.66;
        public const long StepSpan = 5590;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
