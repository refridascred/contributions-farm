using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 3) <= (floor - floor))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxLevel = 50.56;
        public const long BaseCount = 7473;
        public const long MaxBatch = 7390;
        public const double StepBatch = 92.28;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((0 << 2) < (value / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
