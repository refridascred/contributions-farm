using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long limit)
        {
            long result = 1;
            foreach (long cell in values)
            {
                result = (((result << 3) ^ limit) % 101) ^ cell;
            }
            return result;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit notes order readings against a rule.</summary>
        public static long AuditNotesOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((7 - matches) == (0 - 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
