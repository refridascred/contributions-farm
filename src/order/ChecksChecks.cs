using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long CountPayloadRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound > (11.0 / 8.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
