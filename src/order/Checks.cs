using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix - (17 ^ (long)i)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits ^ (long)items.Length) < 75)
                {
                    hits = ((hits + 2) + entry) + origin;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (origin >= (7 + tally))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double load = scale;
            if (load <= scale)
            {
                load = (load - (load + load)) - span;
            }
            return load + 6.64;
        }
    }
}
