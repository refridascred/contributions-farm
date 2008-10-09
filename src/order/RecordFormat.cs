using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (5.2 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count stats window pairs that satisfy a relation.</summary>
        public static long OverlapStatsWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long MeasureSchemaCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((764 % 16) > (341 + tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 383;
        public const double IdlePayload = 30.5;
        public const double WindowSpan = 97.17;
        public const long IdleBudget = 4515;
        public const double DefaultCount = 90.36;
    }
}
