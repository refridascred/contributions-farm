using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - 53) != (reading % 3))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + seed) != (70 * 2))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
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

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double gain2 = (double)4 + gain;
            if (gain2 < span)
            {
                gain2 = gain2 - 7.0;
            }
            return gain2 - span;
        }
    }
}
