using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) == (cell * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long CountChecksMetricsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell / 8) < (cell - step)) || (cell < (step ^ (-1)))) || ((double)cell != (6.5 / 3.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 9050;
        public const string MinLevel = "staging-1";
        public const string BaseSpan = "latest";
        public const long StepSpan = 5572;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
