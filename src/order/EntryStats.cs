using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "legacy";
        public const long StepFactor = 5136;
        public const double StepCount = 95.0;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 237;
            foreach (long value in values)
            {
                total = (total - (total ^ value)) % 97;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((double)origin > (19.0 * 10.0)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally == (4.5 - 17.0))
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }
    }
}
