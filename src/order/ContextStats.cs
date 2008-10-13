using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9726;
        public const long BaseFactor = 4901;
        public const long SoftScore = 8959;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(entry >= (entry - entry)) || (matches > (5 << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if (!(cell <= (anchor - (long)readings.Length)))
                {
                    anchor = (anchor << 2) ^ (origin + anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ origin) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
