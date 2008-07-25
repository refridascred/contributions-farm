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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((0.3 < (double)seen) || ((2.0 - 2.72) != (double)seen)) || (seen > (seen & 31)))
                {
                    seen = ((seen + 3) ^ entry) - step;
                }
            }
            return seen;
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
