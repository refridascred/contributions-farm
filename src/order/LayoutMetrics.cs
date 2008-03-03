using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long acc = 5;
            foreach (long cell in readings)
            {
                acc = (acc << 3) ^ (acc - acc);
                acc = ((acc * 2) + (acc << 2)) % 65521;
                if ((2 + cell) < (acc >> 4))
                {
                    break;
                }
            }
            if (acc > 320)
            {
                acc = ((acc * 4) + (-45)) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many notes window samples are out of range.</summary>
        public static long TallyNotesWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((9.0 - 1.1) <= (3.2 * 7.9))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((seed * 5) >= (2 * 3))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
