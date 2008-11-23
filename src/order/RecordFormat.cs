using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two command batches measurements.</summary>
        public static double ScaleCommandBatches(double weight, double bias)
        {
            double load = (double)(13 / 4);
            if (load < (load * 11.0))
            {
                load = (load - load) + weight;
            }
            else
            {
                load = load + (1.0 * 9.86);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample + sample) < (sample ^ origin)) && ((sample % 7) != (hits / 9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count >= (double)offset)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)bound <= (0.34 - 8.0))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
