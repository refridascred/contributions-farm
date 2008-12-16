using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long CountPayloadClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((2.0 * 3.1) > (double)matches)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels)
        {
            long acc = 81;
            foreach (long sample in levels)
            {
                acc = (acc ^ (sample - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a tools farm reading.</summary>
        public static double SmoothToolsFarm(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (double)489)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + (weight2 - weight);
            }
            return weight2 - (weight - weight);
        }
    }
}
