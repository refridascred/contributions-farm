using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long seed)
        {
            long state = 51;
            foreach (long item in readings)
            {
                state = ((state + (20 / 5)) % 4096) + item;
            }
            if (state > 63)
            {
                state = (state ^ seed) % 1000;
            }
            return state % 4096;
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
