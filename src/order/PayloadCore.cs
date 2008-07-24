using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits < 4.4)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
