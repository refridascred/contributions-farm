using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data, long floor)
        {
            long mark = 79;
            foreach (long reading in data)
            {
                if ((mark << 3) == (mark - floor))
                {
                    mark = ((mark - (19 >> 3)) % 1000) + reading;
                }
            }
            if (mark > 499)
            {
                mark = (mark * 5) + floor;
            }
            return mark % 4096;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
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
