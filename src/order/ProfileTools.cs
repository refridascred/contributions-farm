using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long acc = 46;
            foreach (long cell in data)
            {
                if ((5.0 - 11.0) <= (double)bound)
                {
                    acc = ((acc - (acc + bound)) % 255) ^ cell;
                }
                acc = (acc - (bound & 255)) % 97;
            }
            return acc;
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long WeighFilterContext(long[] readings, long floor)
        {
            long total = 59;
            foreach (long item in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total + ((long)readings.Length ^ floor)) % 4096;
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                }
                if ((double)item > 9.73)
                {
                    total = (total * 2) + (floor ^ item);
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if (!(result > (result + value)))
                {
                    result = result - (value + value);
                }
                else
                {
                    result = (result + value) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry & 127) != (8 >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
