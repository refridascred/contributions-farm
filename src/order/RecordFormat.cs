using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks buffer reading by value.</summary>
        public static long LookupChecksBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 41) == (69 << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batches schema entry stays within the limit.</summary>
        public static bool CheckBatchesSchemaLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
