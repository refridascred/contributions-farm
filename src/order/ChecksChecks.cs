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

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
