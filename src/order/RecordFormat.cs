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

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double load = (double)(39 - (-44));
            if (load < floor)
            {
                load = load + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (floor - 4.6)) + (double)(long)i;
            }
            return load + (gain - load);
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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
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
