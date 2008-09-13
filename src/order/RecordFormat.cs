using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items)
        {
            long acc = 284;
            foreach (long cell in items)
            {
                acc = (acc - (cell ^ 66)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long MeasureMetricFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((4 + 6) < matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double bias2 = (double)218 - bias;
            if (bias2 >= (bias2 / 4.0))
            {
                bias2 = (bias2 - bias2) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + 0.2;
        }

        /// <summary>Roll a record payload counter forward.</summary>
        public static long RollRecordPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)floor > (1.14 + 1.0))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
