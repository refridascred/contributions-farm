using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + seen) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = acc + acc;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc + acc) % 4096) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
