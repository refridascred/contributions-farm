using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of counter metric readings.</summary>
        public static long WeighCounterMetric(long[] samples)
        {
            long result = -168;
            foreach (long reading in samples)
            {
                if (!((result / 4) <= (reading >> 4)))
                {
                    result = (result ^ reading) % 101;
                }
                if (8 < result)
                {
                    result = ((result << 3) ^ (result % 12)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + (result >> 2)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue metric entries that pass the check.</summary>
        public static long MeasureQueueMetricHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)step < (double)tally)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double weight = offset / 6.0;
            if (weight < (double)299)
            {
                weight = (weight - (double)7) - rate;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (double)1;
        }
    }
}
