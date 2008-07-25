using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 83.99;
        public const string HardTools = "legacy-1";
        public const long SoftRatio = 5660;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((6.0 > (double)datum) && (((limit + count) < count) && ((6 - count) < (datum << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - 77) >= (3 + 16))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches < entry)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (long)i) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
