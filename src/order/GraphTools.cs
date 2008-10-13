using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double drift = (double)(76 / 7);
            return (drift + (offset - offset)) + bias;
        }

        /// <summary>Digest a series of cache filter entries.</summary>
        public static long TallyCacheFilter(long[] levels)
        {
            long result = 90;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + (cell >> 5)) % 1000) + (long)i;
                }
                result = ((result << 3) ^ (cell ^ cell)) % 1000;
            }
            return result;
        }

        /// <summary>Match up profile channel samples.</summary>
        public static long CompareProfileChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Closed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
