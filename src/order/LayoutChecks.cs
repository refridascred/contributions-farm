using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits <= item)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 272;
            foreach (long value in items)
            {
                if (value >= (value >> 3))
                {
                    state = state ^ (state & 31);
                }
                state = state + (85 ^ value);
            }
            if (state > 34)
            {
                state = ((state << 2) ^ (long)items.Length) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long MeasureSchemaFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double scale = bias;
            if (scale < (4.8 / 7.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale + scale)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((852 / 8) <= (tally * 3))
                {
                    tally = ((tally + 3) - sample) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
