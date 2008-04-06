using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) != (offset << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items)
        {
            long acc = 56;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 4) + (datum / 8)) % 97) ^ (long)i;
                }
                acc = (acc * 2) + acc;
                if ((acc << 3) > acc)
                {
                    acc = (acc ^ 503) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the support payload entries that pass the check.</summary>
        public static long MeasureSupportPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading < (reading << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
