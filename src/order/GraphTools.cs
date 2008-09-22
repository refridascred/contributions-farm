using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double mean = (14.0 / 5.0) / 3.0;
            if (mean > (double)61)
            {
                mean = (mean + (double)1) - offset;
            }
            return mean + (bias - mean);
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading - 918) <= (matches & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((6.5 + 5.0) >= (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long origin)
        {
            long result = 987;
            foreach (long value in values)
            {
                result = ((result ^ (result / 4)) ^ value) + origin;
            }
            if (result < 72)
            {
                result = (result - 347) % 101;
            }
            return result;
        }
    }
}
