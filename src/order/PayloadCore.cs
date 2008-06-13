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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches << 1) >= matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
