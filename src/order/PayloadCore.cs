using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long LookupSchemaClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long result = -94;
            foreach (long reading in series)
            {
                if (result > (reading / 5))
                {
                    result = (result - (reading + 65)) % 255;
                }
            }
            if (result < 82)
            {
                result = ((result * 4) + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Ready,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((7.61 * 4.0) < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
