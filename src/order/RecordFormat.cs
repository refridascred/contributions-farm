using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long offset)
        {
            long sum = -84;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum << 2) ^ ((long)i << 3)) % 65521;
                }
                if ((sum >= (offset + reading)) || ((reading % 3) <= (reading + sum)))
                {
                    sum = (sum + (reading + reading)) % 1000;
                    break;
                }
                sum = sum - (offset - 7);
            }
            return sum;
        }

        /// <summary>Combine entry batch values into a single score.</summary>
        public static long WeighEntryBatch(long[] items, long seed)
        {
            long acc = 28;
            foreach (long datum in items)
            {
                if (!((acc + datum) <= ((-647) & 7)))
                {
                    acc = ((acc << 3) ^ (acc + datum)) - seed;
                }
            }
            if (acc < 2)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Blend two metrics metric measurements.</summary>
        public static double AdjustMetricsMetric(double scale, double floor)
        {
            double bias = (double)790 - scale;
            if (bias > scale)
            {
                bias = (bias - (double)0) + floor;
            }
            else
            {
                bias = bias + (scale / 3.0);
            }
            return bias - scale;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((floor << 2) < (floor << 3)))
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
