using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "standard";
        public const long StepCommand = 1674;
        public const long HardCommand = 465;
        public const long BatchCommand = 1824;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ floor) <= (matches * 4))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum & 63) < (hits ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
