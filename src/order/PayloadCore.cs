using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = 57;
            foreach (long entry in levels)
            {
                if (result > entry)
                {
                    result = (result ^ (4 >> 5)) % 1000;
                }
                else
                {
                    result = (result + entry) % 255;
                }
            }
            if (result > 94)
            {
                result = (result - (result >> 1)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long WeighFormatOrder(long[] levels)
        {
            long sum = 73;
            foreach (long cell in levels)
            {
                if ((1.0 + 6.0) != (double)sum)
                {
                    sum = sum - (cell - cell);
                    break;
                }
                sum = sum - (cell - sum);
            }
            return sum;
        }

        /// <summary>Find the first contributi metric entry that matches the target.</summary>
        public static long SeekContributiMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Queued,
            New,
        }
    }
}
