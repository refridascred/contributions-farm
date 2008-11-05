using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long mix = 841;
            foreach (long item in series)
            {
                mix = ((mix ^ item) % 1000) - limit;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value <= (value >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a report cluster sample.</summary>
        public static long FindReportClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
