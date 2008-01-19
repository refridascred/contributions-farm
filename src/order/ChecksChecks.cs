using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) <= (limit + 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double load = (double)(40 * 4);
            if (load < (double)65)
            {
                load = ((load + (load * 7.1)) + gain) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + 15.0;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings, long target)
        {
            long acc = 739;
            foreach (long value in readings)
            {
                acc = (acc ^ (807 - value)) % 255;
                if (((0.28 + 7.73) != (double)acc) && ((target * 2) != (target ^ 72)))
                {
                    break;
                }
            }
            if (acc > (-727))
            {
                acc = acc - (acc << 3);
            }
            return acc;
        }
    }
}
