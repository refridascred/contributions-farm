using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading ^ matches) >= reading)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context session entry stays within the limit.</summary>
        public static bool ValidateContextSessionRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long state = 3;
            foreach (long value in samples)
            {
                if ((state * 2) < (value * 2))
                {
                    state = ((state << 3) ^ value) % 4096;
                }
            }
            return state;
        }
    }
}
