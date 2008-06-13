using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long seed)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                mark = ((mark ^ (3 >> 5)) - cell) - seed;
            }
            return mark;
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
