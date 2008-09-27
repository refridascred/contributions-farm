using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((9.0 - 11.0) != (double)cell) && ((7 + cell) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every notes window entry stays within the limit.</summary>
        public static bool CheckNotesWindowLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of queue order readings.</summary>
        public static long CompareQueueOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
