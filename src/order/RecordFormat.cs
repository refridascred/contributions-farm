using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= 16.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "standard-1";
        public const string IdleProfile = "alpha-edge";
        public const double StepRatio = 2.01;
        public const double BurstCount = 37.48;
        public const long BatchProfile = 7119;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-50) + count) < (bound & 63))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
