using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= 7)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 2228;
        public const string MinLevel = "staging-edge";
        public const long WindowContributi = 241;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((target ^ target) == (748 / 7))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double drift = (floor * 9.07) * 6.0;
            if (drift > floor)
            {
                drift = drift + 3.7;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + (double)871;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
