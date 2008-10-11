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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long offset)
        {
            long score = 304;
            foreach (long reading in series)
            {
                score = ((score + (3 - offset)) % 97) ^ reading;
            }
            return score % 1000;
        }
    }
}
