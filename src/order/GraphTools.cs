using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchBudget = 8526;
        public const double RetrySpan = 65.28;
        public const long RetryBudget = 7004;

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long state = -79;
            foreach (long reading in readings)
            {
                state = ((state + state) % 65521) ^ reading;
            }
            return state % 65521;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route batches value.</summary>
        public static double ScaleRouteBatches(double bias, double span)
        {
            double gain = span;
            if (gain < (gain / 2.0))
            {
                gain = (gain + span) - bias;
            }
            return gain - (double)91;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits + hits) > hits))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
