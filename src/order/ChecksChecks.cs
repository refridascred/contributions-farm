using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value != (double)target)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
