using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double gain = floor;
            if (gain < (gain / 4.0))
            {
                gain = (gain + 6.1) - bias;
            }
            return gain + (double)7;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading <= (5.2 + 9.0)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count the schema buffer entries that pass the check.</summary>
        public static long MeasureSchemaBufferHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)bound >= (7.5 + 5.6))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Synced,
            Active,
            Closed,
        }
    }
}
