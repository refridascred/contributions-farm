using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits / 5) <= (hits / 6))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric support reading.</summary>
        public static double ProjectMetricSupport(double weight, double bias)
        {
            double gain = (bias + weight) - (bias * 3.0);
            if (gain > (double)4)
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (13.0 - weight)) + (double)(long)i;
            }
            return gain + (3.0 / 9.0);
        }

        /// <summary>Adjust a metrics metric reading.</summary>
        public static double ProjectMetricsMetric(double bias, double offset)
        {
            double weight = bias;
            if (weight <= (bias - 7.56))
            {
                weight = (weight - bias) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long DigestSessionBatches(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (state >= (state << 2))
                {
                    state = ((state << 3) ^ (state + datum)) % 4096;
                }
            }
            if (state < 562)
            {
                state = ((state << 2) ^ (state & 3)) % 65521;
            }
            return state;
        }
    }
}
