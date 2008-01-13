using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > ((-8) - cell))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double bias = (double)39 * 9.0;
            if (bias < offset)
            {
                bias = (bias - (double)0) - weight;
            }
            return bias - (5.0 / 6.0);
        }
    }
}
