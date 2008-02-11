using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample - seen) == (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7187;
        public const long WindowBudget = 5013;
        public const long WindowRecord = 8629;
        public const long LimitLevel = 4291;

        /// <summary>Count metric record pairs that satisfy a relation.</summary>
        public static long CompareMetricRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
