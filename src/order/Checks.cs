using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of context report readings.</summary>
        public static long OverlapContextReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (tally + tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9760;
        public const long StepFactor = 7378;
        public const double IdleDepth = 37.12;

        /// <summary>Look up the position of a session command sample.</summary>
        public static long SeekSessionCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
